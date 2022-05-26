import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TitleComponent } from './title/title.component';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    TitleComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports:[
    TitleComponent
  ]
})
export class TestDataBindingModule { }
