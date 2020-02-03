import { Component, OnInit } from '@angular/core';
import { AeronaveService } from '../shared/aeronave.service';
import { Router } from '@angular/router';
import { Aeronave } from '../shared/aeronave';
import { ModeloaeronaveService } from 'src/app/modeloaeronave/shared/modeloaeronave.service';
import { Modeloaeronave } from 'src/app/modeloaeronave/shared/modeloaeronave';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  aeronave: Aeronave = new Aeronave();
  submitted = false;
  modeloaeronave: Modeloaeronave;

  constructor(private aeronaveService: AeronaveService, private router: Router, private modeloaeronaveService: ModeloaeronaveService) { }

  ngOnInit() {

    this.modeloaeronaveService.buscarModeloAeronaves()
    .subscribe(data => {
      this.modeloaeronave = data;
    });
  }

  novaAeronave(): void {
    this.submitted = false;
    this.aeronave = new Aeronave();
  }


  salvar() {
    this.aeronaveService.salvarAeronave(this.aeronave)
      .subscribe(data => console.log(data), error => console.log(error));
    this.aeronave = new Aeronave();
    new Promise(resolve => {
      setTimeout(() => {
      }, 7000);
    });
    this.retornaList();
  }

  onSubmit() {
    this.submitted = true;
    this.salvar();
  }

  retornaList() {
    this.router.navigate(['/list']);
  }
}
