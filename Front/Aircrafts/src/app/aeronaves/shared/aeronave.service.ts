import { Aeronave } from './aeronave';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AeronaveService {

  url = 'http://localhost:49546/api/Aeronave';

  constructor(private httpClient: HttpClient) { }

  buscarAeronaves(): Observable<any> {
    return this.httpClient.get(this.url);
  }

  buscarAeronavesPorId(Id: number): Observable<any> {
    return this.httpClient.get(this.url + '/' + Id);
  }

  atualizarAeronave(Id: number, aeronave: Aeronave): Observable<Aeronave> {
    return this.httpClient.put<Aeronave>(this.url + '/' + Id, aeronave);
  }

  salvarAeronave(aeronave: Aeronave): Observable<Aeronave> {
    return this.httpClient.post<Aeronave>(this.url, aeronave);
  }

  deleteAeronave(id: number): Observable<any> {
    return this.httpClient.delete(this.url + id);
  }

}
