import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { livro } from '../models/livro.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LivrariaService {

  apiUrl = 'https://localhost:7164';

  constructor(private http: HttpClient) { }


  getAllLivros(): Observable<livro[]>{
    return this.http.get<livro[]>(this.apiUrl + "/api/Livro")
  }

  addLivro(addLivroRequest: livro): Observable<livro>{
    return this.http.post<livro>(this.apiUrl + "/api/Livro", addLivroRequest);
  }

  getLivro(id: number): Observable<livro>{
    return this.http.get<livro>(this.apiUrl + '/api/Livro/' + id)
  }
}
