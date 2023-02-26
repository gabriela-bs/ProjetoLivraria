import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LivrariaAddComponent } from './livraria-add.component';

describe('LivrariaAddComponent', () => {
  let component: LivrariaAddComponent;
  let fixture: ComponentFixture<LivrariaAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LivrariaAddComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LivrariaAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
