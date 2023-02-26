import { Component, OnInit } from '@angular/core';
import { livrariaService } from './services/livraria.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Frontend';

  constructor(private livrariaService: livrariaService){

  }

  ngOnInit(): void {

    this.listaLivros();
  }

  listaLivros(){
    this.livrariaService.listaLivros().subscribe(
      response => {
        console.log(response);
      }
    );
  }

  }

