import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MyFirstPageComponent } from './my-first-page/my-first-page.component';



@NgModule({
  declarations: [
    MyFirstPageComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    MyFirstPageComponent
  ]
})
export class Homework1Module { }
