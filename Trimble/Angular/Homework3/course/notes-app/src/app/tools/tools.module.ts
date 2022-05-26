import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddNoteComponent } from './add-note/add-note.component';
import { FilterComponent } from './filter/filter.component';
import { ToolsComponent } from './tools/tools.component';



@NgModule({
  declarations: [
    AddNoteComponent,
    FilterComponent,
    ToolsComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ToolsModule { }
