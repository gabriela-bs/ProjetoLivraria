import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LivrosListComponent } from './componentes/livros/livros-list/livros-list.component';
import { AddLivroComponent } from './componentes/livros/add-livro/add-livro.component';
import { HttpClientModule } from '@angular/common/http';
import { LivrariaService } from './services/livraria.service';
import { FormsModule } from '@angular/forms';
import { EditLivroComponent } from './componentes/livros/edit-livro/edit-livro.component';

@NgModule({
  declarations: [
    AppComponent,
    LivrosListComponent,
    AddLivroComponent,
    EditLivroComponent
  ],
  
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [ ],
  bootstrap: [AppComponent]
})
export class AppModule { }
