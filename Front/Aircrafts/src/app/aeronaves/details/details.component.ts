import { Component, OnInit } from '@angular/core';
import { Aeronave } from '../shared/aeronave';
import { ActivatedRoute, Router } from '@angular/router';
import { AeronaveService } from '../shared/aeronave.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {

  id: number;
  aeronave: Aeronave;

  constructor(private route: ActivatedRoute, private router: Router, private aeronaveService: AeronaveService) { }

  ngOnInit() {
    this.aeronave = new Aeronave();
    // this.route.params.subscribe(params => { this.id = + params[' Id ']; });
    this.route.params.subscribe(params => {
      console.log(params);
      this.id = + params.Id;
    });


    this.aeronaveService.buscarAeronavesPorId(this.id)
      .subscribe(data => {
        console.log(data)
        this.aeronave = data;
      }, error => console.log(error));


  }
  list() {
    this.router.navigate(['list']);
  }
}
