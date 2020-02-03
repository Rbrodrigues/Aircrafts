import { Component, OnInit } from '@angular/core';
import { Modeloaeronave } from '../shared/modeloaeronave';
import { ModeloaeronaveService } from '../shared/modeloaeronave.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateModeloAeronaveComponent implements OnInit {

  modeloaeronave: Modeloaeronave = new Modeloaeronave();
  submitted = false;

  constructor(private aeronaveService: ModeloaeronaveService, private router: Router) { }

  ngOnInit() {
  }

  novaAeronave(): void {
    this.submitted = false;
    this.modeloaeronave = new Modeloaeronave();
  }

  salvar() {
    this.aeronaveService.salvarModeloAeronave(this.modeloaeronave)
      .subscribe(data => console.log(data), error => console.log(error));
    this.modeloaeronave = new Modeloaeronave();
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
    this.router.navigate(['/modelolist']);
  }
}
