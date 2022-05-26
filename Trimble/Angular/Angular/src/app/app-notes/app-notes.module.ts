import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { HomeComponent } from './home/home.component';
import { NoteComponent } from './note/note.component';
import { AddNoteComponent } from './add-note/add-note.component';
import { FilterComponent } from './filter/filter.component';
import { ToolsComponent } from './tools/tools.component';

import { AppRoutingModule } from '../app-routing.module';
import { EditNoteComponent } from './edit-note/edit-note.component';
import { HttpMockApiInterceptor } from './services/http-mock-api.interceptor';

@NgModule({
  declarations: [
    HomeComponent,
    NoteComponent,
    AddNoteComponent,
    FilterComponent,
    ToolsComponent,
    EditNoteComponent
  ],
  imports: [
    CommonModule,
    MatIconModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatInputModule,
    MatButtonModule,
    MatFormFieldModule,
    FormsModule,
    MatSelectModule,
    HttpClientModule
  ],
  exports: [
    NoteComponent,
    AddNoteComponent,
    EditNoteComponent
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttpMockApiInterceptor,
      multi: true
    }]
,
})
export class AppNotesModule { }
