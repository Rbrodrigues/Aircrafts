import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Modeloaeronave } from '../shared/modeloaeronave';
import { ModeloaeronaveService } from '../shared/modeloaeronave.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditModeloAeronaveComponent implements OnInit {

  id: number;
  modeloaeronave: Modeloaeronave;

  constructor(private route: ActivatedRoute, private router: Router, private modeloAeronaveService: ModeloaeronaveService) { }



  ngOnInit() {
    this.modeloaeronave = new Modeloaeronave();

    this.route.params.subscribe(params => {
      this.id = + params.Id;
    });

    console.log(this.id);
    this.modeloAeronaveService.buscarModeloAeronavesPorId(this.id)
      .subscribe(data => {
        console.log(data)
        this.modeloaeronave = data;
      }, error => console.log(error));
  }

  atualizarModeloAeronave() {
    this.modeloAeronaveService.atualizarModeloAeronave(this.id, this.modeloaeronave)
      .subscribe(data => console.log(data), error => console.log(error));
    this.modeloaeronave = new Modeloaeronave();
    new Promise ( resolve => {setTimeout(() => {}, 7000);});
    this.RetornaList();
  }

  onSubmit() {
    this.atualizarModeloAeronave();
  }

  RetornaList() {
    this.router.navigate(['/modelolist']);
  }
}
