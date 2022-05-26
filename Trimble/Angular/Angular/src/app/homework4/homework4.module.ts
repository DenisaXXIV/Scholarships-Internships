import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MyPipePipe } from './my-pipe.pipe';
import { MyDirectiveDirective } from './my-directive.directive';
import { ContentComponent } from './content/content.component';



@NgModule({
  declarations: [
    MyPipePipe,
    ContentComponent,
    MyDirectiveDirective
  ],
  imports: [
    CommonModule
  ]
})
export class Homework4Module { }
