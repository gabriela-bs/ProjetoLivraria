import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { livro } from 'src/app/models/livro.model';
import { LivrariaService } from 'src/app/services/livraria.service';

@Component({
  selector: 'app-edit-livro',
  templateUrl: './edit-livro.component.html',
  styleUrls: ['./edit-livro.component.css']
})
export class EditLivroComponent implements OnInit {


  livroDetalhe: livro = {
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

  constructor (private route:ActivatedRoute, private livrariaService: LivrariaService) {}


  ngOnInit(): void {
    
/*    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if(id){
          this.livrariaService.getLivro()
          .subscribe({
            next: (response) => {
              this.livroDetalhe = response;
            }
          })
          
        }
      }
    })*/
  }

}
