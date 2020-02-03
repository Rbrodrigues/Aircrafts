import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EditComponent } from './aeronaves/edit/edit.component';
import { ListComponent } from './aeronaves/list/list.component';
import { HttpClientModule } from '@angular/common/http';
import { DetailsComponent } from './aeronaves/details/details.component';
import { CreateComponent } from './aeronaves/create/create.component';

import { EditModeloAeronaveComponent } from './modeloaeronave/edit/edit.component';
import { ListModeloAeronaveComponent } from './modeloaeronave/list/list.component';
import { DetailsModeloAeronaveComponent } from './modeloaeronave/details/details.component';
import { CreateModeloAeronaveComponent } from './modeloaeronave/create/create.component';
import { RelatorioAeronavesComponent } from './relatorios/relatorio-aeronaves/relatorio-aeronaves.component';


@NgModule({
  declarations: [
    AppComponent,
    EditComponent,
    ListComponent,
    DetailsComponent,
    CreateComponent,
    EditModeloAeronaveComponent,
    ListModeloAeronaveComponent,
    DetailsModeloAeronaveComponent,
    CreateModeloAeronaveComponent,
    RelatorioAeronavesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
