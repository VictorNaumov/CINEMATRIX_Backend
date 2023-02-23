import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ErrorModule } from 'src/app/content/layout/error/error.module';
import { LoadingModule } from 'src/app/content/layout/loading/loading.module';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { MoviesRoutes } from '../movies/movies-routing';
import { PersonDetailComponent } from './components/person-detail.component';
import { PersonDetailRoutes } from './person-detail-routing';

@NgModule({
  declarations: [PersonDetailComponent],
  imports: [
    CommonModule,
    PersonDetailRoutes,
    MaterialModule,
    MoviesRoutes,
    LoadingModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    ErrorModule,
  ]
})
export class PersonDetailModule { }
