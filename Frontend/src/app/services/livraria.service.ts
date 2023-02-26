import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class livrariaService {

  apiUrl = 'https://localhost:7164/api/Livro';

  constructor(private http: HttpClient) { }

  listaLivros(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

  addLivros(data:any){
    return this.http.post<any[]>(this.apiUrl, data);
  }

  atualizaLivro(id:number|string, data:any){
    return this.http.put(this.apiUrl + '$/{id}', data);
  }

  deletaLivro(id:number|string){
    return this.http.delete(this.apiUrl + '$/{id}');
  }

  // tabela autor
  listaAutores(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

  addAutores(data:any){
    return this.http.post<any[]>(this.apiUrl, data);
  }

  atualizaAutor(id:number|string, data:any){
    return this.http.put(this.apiUrl + '$/{id}', data);
  }

  deletaAutor(id:number|string){
    return this.http.delete(this.apiUrl + '$/{id}');
  }


}

