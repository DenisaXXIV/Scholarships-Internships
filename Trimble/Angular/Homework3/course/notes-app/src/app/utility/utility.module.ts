import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FiltersService } from './services/filters.service';
import { NoteService } from './services/note.service';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  exports: [
    FiltersService,
    NoteService
  ]
})
export class UtilityModule { }
