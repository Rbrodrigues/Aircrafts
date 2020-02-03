import { TestBed } from '@angular/core/testing';

import { ModeloaeronaveService } from './modeloaeronave.service';

describe('ModeloaeronaveService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ModeloaeronaveService = TestBed.get(ModeloaeronaveService);
    expect(service).toBeTruthy();
  });
});
