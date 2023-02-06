import { NgModule } from '@angular/core';
import { PagesRoutingModule } from './pages-routing-module';
import { PagesComponent } from './pages.component';
import { CommonModule } from '@angular/common';
import { LoadingModule } from '../layout/loading/loading.module';
import { SignInPageComponent } from './sign-in-page/sign-in-page.component';
import { SignUpPageComponent } from './sign-up-page/sign-up-page.component';
import { HomePageComponent } from './home-page/home-page.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { MoviesPageComponent } from './movies-page/movies-page.component';
import { MovieDetailPageComponent } from './movie-detail-page/movie-detail-page.component';
import { StarRatingModule } from 'angular-star-rating';
import { MovieDetailSliderComponent } from './movie-detail-page/movie-detail-slider/movie-detail-slider.component';
import { AboutPageComponent } from './about-page/about-page.component';
import { GenresPipe } from 'src/app/shared/pipes/genres.pipe';
import { RuntimePipe } from 'src/app/shared/pipes/runtime.pipe';
import { ProfilePageComponent } from './profile-page/profile-page.component';
import { SessionsPageComponent } from './sessions-page/sessions-page.component';
import { ErrorModule } from '../layout/error/error.module';
import { FAQPageComponent } from './faq-page/faq-page.component';
import { MovieCommentTreeComponent } from './movie-detail-page/movie-comments-tree/movie-comments-tree.component';
import { ProfileTicketsComponent } from './profile-page/profile-tickets-table/profile-tickets-table.component';
import { PersonDetailPageComponent } from './person-detail-page/person-detail.component';
import { managementPageComponent } from './management-page/management-page.component';

@NgModule({
  declarations: [
    PagesComponent,
    SignUpPageComponent,
    SignInPageComponent,
    HomePageComponent,
    MoviesPageComponent,
    managementPageComponent,
    MovieDetailPageComponent,
    MovieDetailSliderComponent,
    MovieCommentTreeComponent,
    ProfileTicketsComponent,
    AboutPageComponent,
    SessionsPageComponent,
    ProfilePageComponent,
    FAQPageComponent,
    PersonDetailPageComponent,
    GenresPipe,
    RuntimePipe,
  ],
  imports: [
    CommonModule,
    PagesRoutingModule,
    LoadingModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    MaterialModule,
    ErrorModule,
    StarRatingModule.forRoot(),

  ],
  exports: [
    PagesComponent
  ],
  providers: []
})
export class PagesModule { }
