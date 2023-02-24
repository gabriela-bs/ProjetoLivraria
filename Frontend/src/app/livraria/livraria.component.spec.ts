import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LivrariaComponent } from './livraria.component';

describe('LivrariaComponent', () => {
  let component: LivrariaComponent;
  let fixture: ComponentFixture<LivrariaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LivrariaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LivrariaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
