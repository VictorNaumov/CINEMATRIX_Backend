import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: "home", loadChildren: () => import('./modules/home/home.module').then(p => p.HomeModule) },
  { path: "faq", loadChildren: () => import('./modules/faq/faq.module').then(p => p.FAQModule) },
  { path: "auth", loadChildren: () => import('./modules/auth/auth.module').then(p => p.AuthModule) },
  // { path: "movies", loadChildren: () => import('./modules/movies/movies.module').then(p => p.MoviesModule) },
  { path: "sessions", loadChildren: () => import('./modules/sessions/sessions.module').then(p => p.SessionsModule) },
  { path: "profile", loadChildren: () => import('./modules/profile/profile.module').then(p => p.ProfileModule) },
  { path: "movieDetail", loadChildren: () => import('./modules/movie-detail/movie-detail.module').then(p => p.MovieDetailModule) },
  { path: "personDetail", loadChildren: () => import('./modules/person-detail/person-detail.module').then(p => p.PersonDetailModule) },
  { path: "management", loadChildren: () => import('./modules/management/management.module').then(p => p.ManagementModule) },
  { path: "**", redirectTo: 'home' },
];

// { path: "profile/:profileId", component: ProfilePageComponent },
// { path: "movieDetails/:movieId", component: MovieDetailPageComponent },
// { path: "personDetails/:personId", component: PersonDetailPageComponent },

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
