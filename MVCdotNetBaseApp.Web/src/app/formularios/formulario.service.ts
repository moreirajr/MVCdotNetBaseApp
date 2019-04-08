import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Formulario } from './formulario';

const baseUrl = 'http://localhost:49410/';

@Injectable()
export class FormularioService {

  constructor(private http: HttpClient) { }

  headers = new HttpHeaders({ 'Access-Control-Allow-Origin': '*' })

  save(formulario: Formulario) {
    return this.http.post<Formulario>(baseUrl + 'Formulario/Salvar', formulario, { headers: this.headers });
  }

  getFormularios() {
    return this.http.get<Formulario>(baseUrl + 'Formulario/Listar');
  }
}
