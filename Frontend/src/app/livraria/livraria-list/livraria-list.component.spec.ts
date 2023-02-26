import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LivrariaListComponent } from './livraria-list.component';

describe('LivrariaListComponent', () => {
  let component: LivrariaListComponent;
  let fixture: ComponentFixture<LivrariaListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LivrariaListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LivrariaListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
