import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyFirstPageComponent } from './my-first-page.component';

describe('MyFirstPageComponent', () => {
  let component: MyFirstPageComponent;
  let fixture: ComponentFixture<MyFirstPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MyFirstPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MyFirstPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
