import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WaterfallComponentComponent } from './waterfall-component.component';

describe('WaterfallComponentComponent', () => {
  let component: WaterfallComponentComponent;
  let fixture: ComponentFixture<WaterfallComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WaterfallComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WaterfallComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
