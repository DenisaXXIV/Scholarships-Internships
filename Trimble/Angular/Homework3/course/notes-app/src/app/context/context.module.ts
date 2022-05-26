import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NoteComponent } from './note/note.component';
import { HomeComponent } from './home/home.component';



@NgModule({
  declarations: [
    NoteComponent,
    HomeComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ContextModule { }
