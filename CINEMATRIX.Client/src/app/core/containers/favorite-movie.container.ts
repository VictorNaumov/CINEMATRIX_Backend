import { Injectable } from '@angular/core';
import { AuthService } from '../account/auth-service';
import { FavoriteMovieSearchIncomingDto } from '../models/favorite-movie/favorite-movie-search-incoming-dto';
import { FavoriteMovieSearchOutgoingDto } from '../models/favorite-movie/favorite-movie-search-outgoing-dto';
import { FavoriteMovieService } from '../services/favorite-movie.service';

@Injectable({
  providedIn: 'root',
})
export class FavoriteMovieContainer {
  favoriteMovies: FavoriteMovieSearchIncomingDto;

  isLoaded = false;

  constructor(
    private favoriteMovieService: FavoriteMovieService,
    private authService: AuthService) { }

  updateFavoriteMovies(): void {
    if(!this.authService.isAuthenticated()){
      this.favoriteMovies.items = [];
      this.favoriteMovies.totalCount = 0;
    }

    let favoriteMoviesParam: FavoriteMovieSearchOutgoingDto = {
      "pageSize": 2000,
      "page": 0,
      "profileIds": [+this.authService.profileId],
      "movieIds": [],
      "ratings": []
    }

    const favoriteMovie$ = this.favoriteMovieService.SearchFavoriteMovie(favoriteMoviesParam)

    favoriteMovie$.subscribe(fm => {this.favoriteMovies = fm; console.log(fm)});
  }

  toggleFavoriteMovie(movieId: number): void {
    if (!this.authService.isAuthenticated())
      return;

    const existedFavoriteMovie = this.favoriteMovies.items.find(fm => fm.movieId == movieId && fm.profileId == +this.authService.profileId);
    if(existedFavoriteMovie){
      this.favoriteMovieService.DeleteFavoriteMovie(existedFavoriteMovie.id).subscribe(any => this.updateFavoriteMovies());
    } else {
      this.favoriteMovieService.CreateFavoriteMovie(movieId).subscribe(newId => {
        if(newId){
          this.updateFavoriteMovies();
        }
      });
    }
  }

  isFavoriteMovie(movieId: number): boolean {
    return this.favoriteMovies?.items.some(fm => fm.movieId == movieId && fm.profileId == +this.authService.profileId);
  }
}
