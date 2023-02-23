import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ErrorModule } from 'src/app/content/layout/error/error.module';
import { LoadingModule } from 'src/app/content/layout/loading/loading.module';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { MoviesRoutes } from '../movies/movies-routing';
import { ProfileComponent } from './components/profile/profile.component';
import { ProfileTicketsComponent } from './components/tickets-table/profile-tickets-table.component';
import { ProfileRoutes } from './profile-routing';


@NgModule({
  declarations: [
    ProfileComponent,
    ProfileTicketsComponent
  ],
  imports: [
    CommonModule,
    ProfileRoutes,
    MaterialModule,
    MoviesRoutes,
    LoadingModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    ErrorModule,
  ]
})
export class ProfileModule { }
