import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Categoria } from "src/app/models/categoria.model";
import { Tarefa } from "src/app/models/tarefa.model";

@Component({
  selector: "app-cadastrar",
  templateUrl: "./cadastrar.component.html",
  styleUrls: ["./cadastrar.component.css"],
})
export class CadastrarComponent {
  titulo: string = "";
  descricao: string = "";
  status: string = "Não iniciada";
  quantidade: number = 0;
  categoriaId: number = 0;
  criadoEm: string = "";
  categorias: Categoria[] = [];

  constructor(
    private client: HttpClient,
    private router: Router,
  ) {}

  ngOnInit(): void {
    this.client
      .get<Categoria[]>("https://localhost:7195/api/categoria/listar")
      .subscribe({
        //A requição funcionou
        next: (categorias) => {
          console.table(categorias);
          this.categorias = categorias;
        },
        //A requição não funcionou
        error: (erro) => {
          console.log(erro);
        },
      });
  }

  cadastrar(): void {
    let tarefa: Tarefa = {
      titulo: this.titulo,
      descricao: this.descricao,
      status: this.status,
      quantidade: this.quantidade,
      categoriaId: this.categoriaId,
    };

    this.client
      .post<Tarefa>(
        "https://localhost:7195/api/tarefa/cadastrar",
        tarefa
      )
      .subscribe({
        //A requição funcionou
        next: (tarefa) => {
          this.router.navigate(["pages/tarefa/listar"]);
        },
        //A requição não funcionou
        error: (erro) => {
          console.log(erro);
        },
      });
  }
}
