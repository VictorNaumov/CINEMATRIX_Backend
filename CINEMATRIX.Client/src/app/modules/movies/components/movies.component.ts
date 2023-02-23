import { TOUCH_BUFFER_MS } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSnackBar, throwToolbarMixedModesError } from '@angular/material';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/core/account/auth-service';
import { FavoriteMovieFoundIncomingDto } from 'src/app/core/models/favorite-movie/favorite-movie';
import { FavoriteMovieSearchIncomingDto } from 'src/app/core/models/favorite-movie/favorite-movie-search-incoming-dto';
import { FavoriteMovieSearchOutgoingDto } from 'src/app/core/models/favorite-movie/favorite-movie-search-outgoing-dto';
import { GenreFoundIncomingDto } from 'src/app/core/models/genre/genre-found-incoming-dto';
import { GenreSearchIncomingDto } from 'src/app/core/models/genre/genre-search-incoming-dto';
import { GenreSearchOutgoingDto } from 'src/app/core/models/genre/genre-search-outgoing-dto';
import { DiscoverMovieOutgoingDto } from 'src/app/core/models/movie/discover-movie-outgoing-dto';
import { MovieSearchIncomingDto } from 'src/app/core/models/movie/movie-search-incoming-dto';
import { MovieSearchOutgoingDto } from 'src/app/core/models/movie/movie-search-outgoing-dto';
import { FavoriteMovieService } from 'src/app/core/services/favorite-movie.service';
import { GenreService } from 'src/app/core/services/genre.service';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';
import { EMPTY_POSTER } from 'src/app/shared/constants/poster.constants';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.scss']
})
export class MoviesComponent implements OnInit {
  public movies$: Observable<MovieSearchIncomingDto> | undefined;
  public genres$: Observable<GenreSearchIncomingDto> | undefined;
  public favoriteMovie: FavoriteMovieSearchIncomingDto;
  public emptyPoster = EMPTY_POSTER;

  public selectedGenre: GenreFoundIncomingDto;

  @ViewChild('drawer') drawer: any;

  public isError: boolean = false;
  public sidePanelOpen: boolean = true;
  public currentPage: number = 0;

  searchString: string = '';

  constructor(public notification: NotificationManager,
    public favoriteMoviesService: FavoriteMovieService,
    public authService: AuthService,
    public movieService: MovieService,
    public genreService: GenreService,
    public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.sendSearchQuery();
    this.sendGenresQuery();

    if (this.authService.isAuthenticated()) {
      this.sendFavoriteMoviesQuery();
    }
  }

  public selectGenre(genre: GenreFoundIncomingDto): void {
    this.selectedGenre = genre;
    this.sendSearchQuery();
  }

  public sendGenresQuery(): void {
    let genreParam: GenreSearchOutgoingDto = {
      "name": []
    }

    this.genres$ = this.genreService.SearchGenre(genreParam);
    this.checkError(this.genres$);
  }

  pageEventHandler(event: any) {
    this.currentPage = event.pageIndex;
    this.sendSearchQuery();
  }

  sendFavoriteMoviesQuery() {
    let favoriteMoviesParam: FavoriteMovieSearchOutgoingDto = {
      "pageSize": 2000,
      "page": 0,
      "profileIds": [+this.authService.profileId],
      "movieIds": [],
      "ratings": []
    }

    const favoriteMovie$ = this.favoriteMoviesService.SearchFavoriteMovie(favoriteMoviesParam)

    favoriteMovie$.subscribe(fm => {this.favoriteMovie = fm; console.log(fm)});

    this.checkError(favoriteMovie$);
  }

  sendSearchQuery() {
    if (this.selectedGenre) {
      let movieParam: DiscoverMovieOutgoingDto = {
        "page": this.currentPage,
        "genres": [this.selectedGenre.id],
        "people": []
      }

      this.movies$ = this.movieService.DiscoverMovies(movieParam)
    } else {
      let movieParam: MovieSearchOutgoingDto = {
        "page": this.currentPage,
        "title": [],
        "searchString": this.searchString
      }

      this.movies$ = this.searchString
        ? this.movieService.SearchMovies(movieParam)
        : this.movieService.GetNowPlayingMovies(movieParam);
    }

    this.checkError(this.movies$);
  }

  writeNotification(text: string) {
    this.notification.textNotice(text);
  }
  toggleFavoriteMovie(movieId: number) {
    if (!this.authService.isAuthenticated()) return;

    const existedFavoriteMovie = this.favoriteMovie.items.find(fm => fm.movieId == movieId && fm.profileId == +this.authService.profileId);
    if(existedFavoriteMovie){
      this.favoriteMoviesService.DeleteFavoriteMovie(existedFavoriteMovie.id).subscribe(any => this.sendFavoriteMoviesQuery());
    } else {
      this.favoriteMoviesService.CreateFavoriteMovie(movieId).subscribe(newId => {
        if(newId){
          this.sendFavoriteMoviesQuery();
        }
      });
    }
  }

  isFavoriteMovie(movieId: number) {
    return this.favoriteMovie?.items.some(fm => fm.movieId == movieId && fm.profileId == +this.authService.profileId);
  }

  toggleSidePanel() {
    this.sidePanelOpen = !this.sidePanelOpen;
    this.drawer.toggle();
  }

  checkError(sub: Observable<any>) {
    sub.subscribe(
      (_) => { },
      error => {
        this.isError = true;
        console.log(error);
        this.snackBar.open(errorMessage, "Close")
      })
  }

}
