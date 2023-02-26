import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddideasComponent } from './addideas.component';

describe('AddideasComponent', () => {
  let component: AddideasComponent;
  let fixture: ComponentFixture<AddideasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddideasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddideasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
