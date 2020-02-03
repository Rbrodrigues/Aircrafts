import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './aeronaves/list/list.component';
import { CreateComponent } from './aeronaves/create/create.component';
import { EditComponent } from './aeronaves/edit/edit.component';
import { DetailsComponent } from './aeronaves/details/details.component';

import { ListModeloAeronaveComponent } from './modeloaeronave/list/list.component';
import { CreateModeloAeronaveComponent } from './modeloaeronave/create/create.component';
import { EditModeloAeronaveComponent } from './modeloaeronave/edit/edit.component';
import { DetailsModeloAeronaveComponent } from './modeloaeronave/details/details.component';
import { RelatorioAeronavesComponent } from './relatorios/relatorio-aeronaves/relatorio-aeronaves.component';

const routes: Routes = [
  { path: '', redirectTo: 'list', pathMatch: 'full' },
  { path: 'list', component: ListComponent },
  { path: 'create', component: CreateComponent },
  { path: 'edit/:Id', component: EditComponent },
  { path: 'details/:Id', component: DetailsComponent },
  { path: 'modelolist', component: ListModeloAeronaveComponent },
  { path: 'modelocreate', component: CreateModeloAeronaveComponent },
  { path: 'modeloedit/:Id', component: EditModeloAeronaveComponent },
  { path: 'modelodetails/:Id', component: DetailsModeloAeronaveComponent },
  { path: 'relatorioaeronaves', component: RelatorioAeronavesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
