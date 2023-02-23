import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ErrorModule } from 'src/app/content/layout/error/error.module';
import { LoadingModule } from 'src/app/content/layout/loading/loading.module';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { MoviesRoutes } from '../movies/movies-routing';
import { FAQComponent } from './components/faq.component';
import { FAQRoutes } from './faq-routing';

@NgModule({
  declarations: [FAQComponent],
  imports: [
    CommonModule,
    FAQRoutes,
    MaterialModule,
    MoviesRoutes,
    LoadingModule,
    MaterialModule,
    ErrorModule,
  ]
})
export class FAQModule { }
