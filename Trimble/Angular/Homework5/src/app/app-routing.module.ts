import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DummyComponentComponent } from './components/dummy-component/dummy-component.component';
import { ShowedComponentComponent } from './components/showed-component/showed-component.component';

const routes: Routes = [
  { path: 'homework', component: ShowedComponentComponent },
  { path: 'homework/dummy/:nr', component: DummyComponentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
