import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { DummyModule1Module } from './dummy-module1/dummy-module1.module'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    DummyModule1Module
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
