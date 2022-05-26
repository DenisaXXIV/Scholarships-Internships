import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VariableTryComponent } from './variable-try.component';

describe('VariableTryComponent', () => {
  let component: VariableTryComponent;
  let fixture: ComponentFixture<VariableTryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VariableTryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VariableTryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
