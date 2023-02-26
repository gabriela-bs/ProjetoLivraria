import { Component, OnInit } from '@angular/core';
import { livro } from 'src/app/models/livro.model';
import { LivrariaService } from 'src/app/services/livraria.service';

@Component({
  selector: 'app-livros-list',
  templateUrl: './livros-list.component.html',
  styleUrls: ['./livros-list.component.css']
})
export class LivrosListComponent implements OnInit{

  livros: livro[] = [];

  constructor( private livrosService: LivrariaService){ }

  ngOnInit(): void {
    this.livrosService.getAllLivros()
    .subscribe({
      next: (livros) => {
        this.livros = livros;
      },

      error: (response) => {
        console.log(response);
      }
    })

  }

}
