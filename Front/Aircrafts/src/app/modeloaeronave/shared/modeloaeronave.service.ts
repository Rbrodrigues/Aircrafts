import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Modeloaeronave } from './modeloaeronave';

@Injectable({
  providedIn: 'root'
})
export class ModeloaeronaveService {

    url = 'http://localhost:49546/api/ModeloAeronave';

  constructor(private httpClient: HttpClient) { }

  buscarModeloAeronaves(): Observable<any> {
    return this.httpClient.get(this.url);
  }

  buscarModeloAeronavesPorId(Id: number): Observable<any> {
    return this.httpClient.get(this.url + '/' + Id);
  }

  atualizarModeloAeronave(Id: number, modeloaeronave: Modeloaeronave): Observable<Modeloaeronave> {
    return this.httpClient.put<Modeloaeronave>(this.url + '/' + Id, modeloaeronave);
  }

  salvarModeloAeronave(modeloaeronave: Modeloaeronave): Observable<Modeloaeronave> {
    return this.httpClient.post<Modeloaeronave>(this.url, modeloaeronave);
  }

  deleteModeloAeronave(id: number): Observable<any> {
    return this.httpClient.delete(this.url + id);
  }
}
