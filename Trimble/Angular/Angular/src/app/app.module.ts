import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppNotesModule } from './app-notes/app-notes.module';
import { FiltersService } from './app-notes/services/filters.service';
import { NoteService } from './app-notes/services/note.service';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Homework1Module } from './homework1/homework1.module';
import { Homework2Module } from './homework2/homework2.module';
import { Homework3Module } from './homework3/homework3.module';
import { Homework4Module } from './homework4/homework4.module';
import { Homework5Module } from './homework5/homework5.module';
import { NavBarModule } from './nav-bar/nav-bar.module';
import { PinService } from './app-notes/services/pin.service';
import { SharedService } from './app-notes/services/shared.service';
import { CommonModule } from '@angular/common';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { HttpMockApiInterceptor } from './app-notes/services/http-mock-api.interceptor';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AppNotesModule,
    CommonModule,

    Homework1Module,
    Homework2Module,
    Homework3Module,
    Homework4Module,
    Homework5Module,
    AppRoutingModule,
    AppNotesModule,
    NavBarModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttpMockApiInterceptor,
      multi: true
    }]
,
  bootstrap: [AppComponent]
})
export class AppModule { }
