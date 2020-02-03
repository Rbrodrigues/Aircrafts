import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RelatorioAeronavesService {

  url = 'http://localhost:49546/api/Relatorio';

  constructor(private httpClient: HttpClient) { }

  relatorioAeronavesAtivas(): Observable<any> {
    return this.httpClient.get(this.url);
  }
}
