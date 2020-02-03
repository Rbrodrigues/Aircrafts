import { AeronaveService } from './../shared/aeronave.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { Aeronave } from '../shared/aeronave';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})

export class ListComponent implements OnInit {

  aeronaves: Observable<Aeronave[]>;

  constructor(private aeronaveService: AeronaveService, private router: Router) { }

  ngOnInit() {
    this.BuscarAeronaves();
  }


  BuscarAeronaves() {
     this.aeronaveService.buscarAeronaves().subscribe( (response) => {
      this.aeronaves = response;
      console.log(this.aeronaves);
  });
}

  deleteAeronave(id: number) {
    this.aeronaveService.deleteAeronave(id)
      .subscribe(
        data => {
          console.log(data);
          this.BuscarAeronaves();
        },
        error => console.log(error));
  }

  aeronaveDetails(Id: number ) {
    this.router.navigate(['details', Id]);
  }

  atualizarAeronave(Id: number ) {
     this.router.navigate(['edit', Id]);
  }

}
