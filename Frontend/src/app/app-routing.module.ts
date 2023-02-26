import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddLivroComponent } from './componentes/livros/add-livro/add-livro.component';
import { EditLivroComponent } from './componentes/livros/edit-livro/edit-livro.component';
import { LivrosListComponent } from './componentes/livros/livros-list/livros-list.component';

const routes: Routes = [
  {
    path: '',
    component: LivrosListComponent
  },

  {
    path: 'livros',
    component: LivrosListComponent
  },

  {
    path: 'livros/add',
    component: AddLivroComponent
  },

  {
    path: 'livros/edit/:id',
    component: EditLivroComponent
  }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
