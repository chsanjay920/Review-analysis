import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IdeasfeedComponent } from './ideasfeed.component';

describe('IdeasfeedComponent', () => {
  let component: IdeasfeedComponent;
  let fixture: ComponentFixture<IdeasfeedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IdeasfeedComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IdeasfeedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
