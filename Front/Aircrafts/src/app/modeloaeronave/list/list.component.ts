import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Modeloaeronave } from '../shared/modeloaeronave';
import { Router } from '@angular/router';
import { ModeloaeronaveService } from '../shared/modeloaeronave.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListModeloAeronaveComponent implements OnInit {

  modeloaeronaves: Observable<Modeloaeronave[]>;

  constructor(private modeloaeronaveService: ModeloaeronaveService, private router: Router) { }

  ngOnInit() {
    this.BuscarModeloAeronaves();
  }


  BuscarModeloAeronaves() {
     this.modeloaeronaveService.buscarModeloAeronaves().subscribe( (response) => {
      this.modeloaeronaves = response;
  });
}

  deleteModeloAeronave(id: number) {
    this.modeloaeronaveService.deleteModeloAeronave(id)
      .subscribe(
        data => {
          console.log(data);
          this.BuscarModeloAeronaves();
        },
        error => console.log(error));
  }

  modeloAeronaveDetails(id: number ) {this.router.navigate(['modelodetails', id]);
  }

  atualizarModeloAeronave(id: number ) {
     this.router.navigate(['modeloedit', id]);
  }
}
