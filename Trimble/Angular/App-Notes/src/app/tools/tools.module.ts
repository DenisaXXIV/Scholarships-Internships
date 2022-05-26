import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';

import { FiltersComponent } from './filters/filters.component';
import { AddComponent } from './add/add.component';
import { NoteComponent } from './note/note.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    FiltersComponent,
    AddComponent,
    NoteComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatIconModule,
    RouterModule
  ],
  exports: [
    AddComponent,
    FiltersComponent,
    NoteComponent
  ]
})
export class ToolsModule { }
