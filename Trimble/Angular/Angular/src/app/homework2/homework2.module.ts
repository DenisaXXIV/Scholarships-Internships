import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DummyComponentComponent } from './dummy-component/dummy-component.component';
import { WaterfallComponentComponent } from './waterfall-component/waterfall-component.component';
import { Homework1Module } from '../homework1/homework1.module';



@NgModule({
  declarations: [
    DummyComponentComponent,
    WaterfallComponentComponent
  ],
  imports: [
    CommonModule,
    Homework1Module
  ],
  exports: [
    DummyComponentComponent,
    WaterfallComponentComponent
  ]
})
export class Homework2Module { }
