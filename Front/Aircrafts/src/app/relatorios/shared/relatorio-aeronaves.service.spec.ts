import { TestBed } from '@angular/core/testing';

import { RelatorioAeronavesService } from './relatorio-aeronaves.service';

describe('RelatorioAeronavesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RelatorioAeronavesService = TestBed.get(RelatorioAeronavesService);
    expect(service).toBeTruthy();
  });
});
