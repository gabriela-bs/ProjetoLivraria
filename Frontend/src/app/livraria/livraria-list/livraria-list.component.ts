import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Observable, ObservedValueOf } from 'rxjs';
import { livrariaService } from '../../services/livraria.service';

@Component({
  selector: 'app-livraria-list',
  templateUrl: './livraria-list.component.html',
  styleUrls: ['./livraria-list.component.css']
})
export class LivrariaListComponent implements OnInit{

  listaLivros$!:Observable<any[]>;
  listaAutores$!:Observable<any[]>;

  //para mostrar associacao entre tabelas ??
  autorMap:Map<number, string> = new Map();


  constructor(private service: livrariaService) {}

  ngOnInit(): void{
    this.listaLivros$ = this.service.listaLivros();

  }

/*  modalTitle:string = '';
  activeAddLivrariaComponent:boolean = false;
  estoque:any;

  modalAdd(){
    this.estoque = {
      id:0,
      titulo:null,
      subtitulo:null,
      resumo:null,
      paginas:0,
      dataPublicacao:null,
      editora:null,
      edicao:null,
      quantLivros:0

    }
    this.modalTitle = "Novo cadastro";
    this.activeAddLivrariaComponent = true;
  }*/

}

