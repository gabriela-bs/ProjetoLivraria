import { Component, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';
import { livro } from 'src/app/models/livro.model';
import { LivrariaService } from 'src/app/services/livraria.service';

@Component({
  selector: 'app-add-livro',
  templateUrl: './add-livro.component.html',
  styleUrls: ['./add-livro.component.css']
})
export class AddLivroComponent implements OnInit {

  addLivroRequest: livro = {
    id: 0,
    titulo: '',
    subtitulo: '',
    resumo: '',
    quantPaginas: 0,
    dataPublicacao: 0,
    editora: '',
    edicao: 0,
    quantLivros: 0
  }

  constructor(private livrariaService: LivrariaService, private router: Router){

  }

  ngOnInit(): void {
    
  }

  addLivro(){
    this.livrariaService.addLivro(this.addLivroRequest)
    .subscribe ({
      next: (livro) => {
        this.router.navigate(['livros'])
      }
    })

  }

}
