import { Modeloaeronave } from './../../modeloaeronave/shared/modeloaeronave';
import { Component, OnInit } from '@angular/core';
import { Aeronave } from '../shared/aeronave';
import { ActivatedRoute, Router } from '@angular/router';
import { AeronaveService } from '../shared/aeronave.service';
import { FormsModule } from '@angular/forms';
import { ModeloaeronaveService } from './../../modeloaeronave/shared/modeloaeronave.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {

  id: number;
  aeronave: Aeronave;
  modeloaeronave: Modeloaeronave;

  constructor(private route: ActivatedRoute, private router: Router, private aeronaveService: AeronaveService,
              private modeloaeronaveService: ModeloaeronaveService ) { }



  ngOnInit() {
    this.aeronave = new Aeronave();

    this.route.params.subscribe(params => {
      this.id = + params.Id;
});


    this.aeronaveService.buscarAeronavesPorId(this.id)
      .subscribe(data => {
        console.log(data)
        this.aeronave = data;
      }, error => console.log(error));

    this.modeloaeronaveService.buscarModeloAeronaves()
      .subscribe(data => {
        this.modeloaeronave = data;
      });
  }

  atualizarAeronave() {
    this.aeronaveService.atualizarAeronave(this.id, this.aeronave)
      .subscribe(data => console.log(data), error => console.log(error));
    this.aeronave = new Aeronave();
    new Promise(resolve => {setTimeout(() => {}, 2000);});
    this.RetornaList();
  }

  onSubmit() {
    this.atualizarAeronave();
  }

  RetornaList() {
    this.router.navigate(['/list']);
  }
}
