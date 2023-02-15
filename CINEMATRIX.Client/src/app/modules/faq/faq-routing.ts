import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FAQComponent } from './components/faq.component';

const routes: Routes = [
  { path: 'faq', component: FAQComponent },
  { path: '**', redirectTo: 'faq' }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FAQRoutes { }
