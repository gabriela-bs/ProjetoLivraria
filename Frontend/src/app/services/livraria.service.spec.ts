import { TestBed } from '@angular/core/testing';

import { livrariaService } from './livraria.service';

describe('LivrariaService', () => {
  let service: livrariaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(livrariaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
