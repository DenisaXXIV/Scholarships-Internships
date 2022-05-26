import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DummyComponentComponent } from './dummy-component/dummy-component.component';
import { ShowedComponentComponent } from './showed-component/showed-component.component';



@NgModule({
  declarations: [
    DummyComponentComponent,
    ShowedComponentComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    DummyComponentComponent
  ]
})
export class ComponentsModule { }
