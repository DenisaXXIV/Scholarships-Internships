import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddNoteComponent } from './app-notes/add-note/add-note.component';
import { EditNoteComponent } from './app-notes/edit-note/edit-note.component';
import { HomeComponent } from './app-notes/home/home.component';

import { MyFirstPageComponent } from './homework1/my-first-page/my-first-page.component';
import { WaterfallComponentComponent } from './homework2/waterfall-component/waterfall-component.component';
import { DataBindingComponent } from './homework3/data-binding/data-binding.component';
import { ContentComponent } from './homework4/content/content.component';
import { VariableTryComponent } from './homework5/variable-try/variable-try.component';

const routes: Routes = [
  {
    path: '',
    children: [
      { path: 'notes', component: HomeComponent },
      { path: 'notes/add-notes', component: AddNoteComponent },
      { path: 'notes/add-notes/:id', component: AddNoteComponent },
      { path: 'notes/edit-notes/:id', component: EditNoteComponent },
      { path: 'homework1', component: MyFirstPageComponent },
      { path: 'homework2', component: WaterfallComponentComponent },
      { path: 'homework3', component: DataBindingComponent },
      { path: 'homework4', component: ContentComponent },
      { path: 'homework5/:nr', component: VariableTryComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
