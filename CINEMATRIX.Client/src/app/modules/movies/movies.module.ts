import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ErrorModule } from 'src/app/content/layout/error/error.module';
import { LoadingModule } from 'src/app/content/layout/loading/loading.module';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { MoviesComponent } from './components/movies.component';
import { MoviesRoutes } from './movies-routing';

@NgModule({
  declarations: [MoviesComponent],
  imports: [
    CommonModule,
    MoviesRoutes,
    MaterialModule,
    MoviesRoutes,
    LoadingModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    ErrorModule,
  ]
})
export class MoviesModule { }
