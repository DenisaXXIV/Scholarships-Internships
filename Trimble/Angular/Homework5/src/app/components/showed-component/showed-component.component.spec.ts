import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowedComponentComponent } from './showed-component.component';

describe('ShowedComponentComponent', () => {
  let component: ShowedComponentComponent;
  let fixture: ComponentFixture<ShowedComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowedComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowedComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
