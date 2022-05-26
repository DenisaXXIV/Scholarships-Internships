import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Component1Component } from './component1/component1.component';
import { Component2Component } from './component2/component2.component';
import { WaterfallModule } from '../waterfall/waterfall.module';



@NgModule({
  declarations: [
    Component1Component,
    Component2Component
  ],
  imports: [
    CommonModule,
    WaterfallModule
  ],
  exports: [
    Component1Component
  ]
})
export class DummyModule1Module { }
