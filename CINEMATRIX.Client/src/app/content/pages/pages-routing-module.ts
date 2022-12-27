import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthGuard } from "src/app/core/guards/auth.guard";
import { PagesComponent } from "./pages.component";
import { SignInPageComponent } from "./sign-in-page/sign-in-page.component";
import { HomePageComponent } from "./home-page/home-page.component";
import { SignUpPageComponent } from "./sign-up-page/sign-up-page.component";
import { MoviesPageComponent } from "./movies-page/movies-page.component";
import { MovieDetailPageComponent } from "./movie-detail-page/movie-detail-page.component";
import { AboutPageComponent } from "./about-page/about-page.component";
import { SessionsPageComponent } from "./sessions-page/sessions-page.component";
import { ProfilePageComponent } from "./profile-page/profile-page.component";
import { FAQPageComponent } from "./faq-page/faq-page.component";

const routes: Routes = [
  {
    path: "",
    component: PagesComponent,
    children: [
      { path: "", component: HomePageComponent },
      { path: "faq", component: FAQPageComponent },
      { path: "signin", component: SignInPageComponent },
      { path: "signup", component: SignUpPageComponent },
      { path: "movies", component: MoviesPageComponent },
      { path: "about", component: AboutPageComponent },
      { path: "sessions", component: SessionsPageComponent },
      { path: "profile", component: ProfilePageComponent },
      { path: "details/:movieId", component: MovieDetailPageComponent },
    ]
  },
  { path: "**", redirectTo: "", pathMatch: "full" }
];

@NgModule({
  imports: [RouterModule.forChild(routes), CommonModule],
  exports: [RouterModule],
  providers: [AuthGuard]
})
export class PagesRoutingModule { }
