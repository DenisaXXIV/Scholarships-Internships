import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddNoteComponent } from './pages/add-note/add-note.component';
import { EditNoteComponent } from './pages/edit-note/edit-note.component';
import { HomeComponent } from './pages/home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'add-notes', component: AddNoteComponent },
  { path: 'add-notes/:id', component: AddNoteComponent },
  { path: 'edit-notes/:id', component: EditNoteComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
