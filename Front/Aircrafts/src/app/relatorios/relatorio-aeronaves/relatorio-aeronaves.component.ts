import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Aeronave } from 'src/app/aeronaves/shared/aeronave';
import { Router } from '@angular/router';
import { RelatorioAeronavesService } from '../shared/relatorio-aeronaves.service';

@Component({
  selector: 'app-relatorio-aeronaves',
  templateUrl: './relatorio-aeronaves.component.html',
  styleUrls: ['./relatorio-aeronaves.component.css']
})
export class RelatorioAeronavesComponent implements OnInit {

  aeronaves: Observable<Aeronave[]>;

  constructor(private relatorioAeronaveService: RelatorioAeronavesService, private router: Router) { }

  ngOnInit() {
    this.relatorioAeronaves();
  }


  relatorioAeronaves() {
     this.relatorioAeronaveService.relatorioAeronavesAtivas().subscribe( (response) => {
      this.aeronaves = response;
  });
}
}
