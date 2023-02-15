import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ErrorModule } from 'src/app/content/layout/error/error.module';
import { LoadingModule } from 'src/app/content/layout/loading/loading.module';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { PipesModule } from 'src/app/shared/pipes/pipes.module';
import { MoviesRoutes } from '../movies/movies-routing';
import { MovieCommentTreeComponent } from './components/comments-tree/movie-comments-tree.component';
import { MovieDetailSliderComponent } from './components/detail-slider/movie-detail-slider.component';
import { MovieDetailComponent } from './components/movie-detail/movie-detail.component';

@NgModule({
  declarations: [
    MovieDetailComponent,
    MovieCommentTreeComponent,
    MovieDetailSliderComponent,
  ],
  imports: [
    CommonModule,
    MaterialModule,
    MoviesRoutes,
    LoadingModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    ErrorModule,
    PipesModule
  ],
})
export class MovieDetailModule { }
