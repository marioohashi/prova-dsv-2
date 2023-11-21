import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";
import { Categoria } from "src/app/models/categoria.model";
import { Tarefa } from "src/app/models/tarefa.model";

@Component({
  selector: "app-listar",
  templateUrl: "./listar.component.html",
  styleUrls: ["./listar.component.css"],
})
export class ListarComponent {
  tarefas: Tarefa[] = [];

  constructor(
    private client: HttpClient,
  ) {
  }

  ngOnInit(): void {
    this.client
      .get<Tarefa[]>("https://localhost:7015/api/tarefa/listar")
      .subscribe({
        next: (tarefas) => {
          console.table(tarefas);
          this.tarefas = tarefas;
        },
        error: (erro) => {
          console.log(erro);
        },
      });
  }
}
