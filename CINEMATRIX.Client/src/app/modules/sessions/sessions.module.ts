import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ErrorModule } from 'src/app/content/layout/error/error.module';
import { LoadingModule } from 'src/app/content/layout/loading/loading.module';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { PipesModule } from 'src/app/shared/pipes/pipes.module';
import { MoviesRoutes } from '../movies/movies-routing';
import { SessionsComponent } from './components/sessions.component';
import { SessionsRoutes } from './sessions-routing';

@NgModule({
  declarations: [
    SessionsComponent,
  ],
  imports: [
    CommonModule,
    SessionsRoutes,
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
export class SessionsModule { }
