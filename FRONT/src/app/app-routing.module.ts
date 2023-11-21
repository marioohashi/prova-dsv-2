import { ListarComponent } from './pages/tarefa/listar/listar.component';
import { AlterarComponent } from './pages/tarefa/alterar/alterar.component';
import { CadastrarComponent } from './pages/tarefa/cadastrar/cadastrar.component';
import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

const routes: Routes = [
  {
    path: "",
    component: ListarComponent,
  },
  {
    path: "pages/tarefa/listar",
    component: ListarComponent,
  },
  {
    path: "pages/tarefa/cadastrar",
    component: CadastrarComponent,
  },
  {
    path: "pages/tarefa/alterar",
    component: AlterarComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
