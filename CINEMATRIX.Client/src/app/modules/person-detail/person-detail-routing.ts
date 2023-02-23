import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonDetailComponent } from './components/person-detail.component';

const routes: Routes = [
  { path: ':personId', component: PersonDetailComponent },
  { path: '**', redirectTo: ':personId' }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PersonDetailRoutes { }
