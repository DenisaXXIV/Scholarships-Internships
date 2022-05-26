import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';

import { AddNoteComponent } from './add-note/add-note.component';
import { EditNoteComponent } from './edit-note/edit-note.component';
import { HomeComponent } from './home/home.component';
import { ToolsModule } from '../tools/tools.module';



@NgModule({
  declarations: [
    AddNoteComponent,
    EditNoteComponent,
    HomeComponent
  ],
  imports: [
    CommonModule,
    ToolsModule,
    MatFormFieldModule,
    FormsModule,
    MatSelectModule,
    MatInputModule,
    MatFormFieldModule
  ],
  exports: [
    AddNoteComponent,
    EditNoteComponent,
    HomeComponent
  ]
})
export class PagesModule { }
