import { ListarComponent } from "./pages/tarefa/listar/listar.component";
import { CadastrarComponent } from "./pages/tarefa/cadastrar/cadastrar.component";
import { AlterarComponent } from "./pages/tarefa/alterar/alterar.component";
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    ListarComponent,
    CadastrarComponent,
    AlterarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, 
    HttpClientModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
