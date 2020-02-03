import { Component, OnInit } from '@angular/core';
import { Modeloaeronave } from '../shared/modeloaeronave';
import { ModeloaeronaveService } from '../shared/modeloaeronave.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsModeloAeronaveComponent implements OnInit {

  id: number;
  modeloaeronave: Modeloaeronave;

  constructor(private route: ActivatedRoute, private router: Router, private modeloaeronaveService: ModeloaeronaveService) { }

  ngOnInit() {
    this.modeloaeronave = new Modeloaeronave();

    this.route.params.subscribe(params => {
      this.id = + params.Id;
    });

    this.modeloaeronaveService.buscarModeloAeronavesPorId(this.id)
      .subscribe(data => {
        console.log(data);
        this.modeloaeronave = data;
      }, error => console.log(error));
  }
  list() {
    this.router.navigate(['modelolist']);
  }
}
