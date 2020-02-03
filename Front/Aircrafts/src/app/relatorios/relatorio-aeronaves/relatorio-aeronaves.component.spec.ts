import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RelatorioAeronavesComponent } from './relatorio-aeronaves.component';

describe('RelatorioAeronavesComponent', () => {
  let component: RelatorioAeronavesComponent;
  let fixture: ComponentFixture<RelatorioAeronavesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RelatorioAeronavesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RelatorioAeronavesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
