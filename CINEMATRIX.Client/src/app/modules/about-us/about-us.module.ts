import { AboutUsRoutes } from './about-us.routing';
import { AboutUsComponent } from './component/about-us.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ErrorModule } from 'src/app/content/layout/error/error.module';
import { LoadingModule } from 'src/app/content/layout/loading/loading.module';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { MoviesRoutes } from '../movies/movies-routing';

@NgModule({
  declarations: [AboutUsComponent],
  imports: [
    CommonModule,
    MaterialModule,
    MoviesRoutes,
    LoadingModule,
    MaterialModule,
    ErrorModule,
    AboutUsRoutes
  ]
})
export class AboutUsModule { }
