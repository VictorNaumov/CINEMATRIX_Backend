import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { forkJoin, Observable, Subscription } from 'rxjs';
import { GenreSearchIncomingDto } from 'src/app/core/models/genre/genre-search-incoming-dto';
import { GenreSearchOutgoingDto } from 'src/app/core/models/genre/genre-search-outgoing-dto';
import { MovieSearchIncomingDto } from 'src/app/core/models/movie/movie-search-incoming-dto';
import { MovieSearchOutgoingDto } from 'src/app/core/models/movie/movie-search-outgoing-dto';
import { GenreService } from 'src/app/core/services/genre.service';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';

@Component({
  selector: 'app-movies-page',
  templateUrl: './movies-page.component.html',
  styleUrls: ['./movies-page.component.scss']
})
export class MoviesPageComponent implements OnInit {
  public movies$: Observable<MovieSearchIncomingDto> | undefined;
  public genres$: Observable<GenreSearchIncomingDto> | undefined;

  @ViewChild('drawer') drawer: any;

  public isError: boolean = false;
  public sidePanelOpen = true;

  searchString: string = '';

  constructor(public notification: NotificationManager,
    public movieService: MovieService,
    public genreService: GenreService,
    public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.sendQuery();
  }

  public sendQuery(): void {
    var movieParam: MovieSearchOutgoingDto = {
      "pageSize": 20,
      "page": 0,
      "sortDirection": "asc",
      "sortProperty": "id",
      "title": [],
      "searchString": ""
    }

    var genreParam: GenreSearchOutgoingDto = {
      "pageSize": 20,
      "page": 0,
      "sortDirection": "asc",
      "sortProperty": "id",
      "name": []
    }

    this.movies$ = this.movieService.GetNowPlayingMovies(movieParam);
    this.checkError(this.movies$);

    this.genres$ = this.genreService.SearchGenre(genreParam);
    this.checkError(this.genres$);
  }

  sendSearchQuery() {

    var movieParam: MovieSearchOutgoingDto = {
      "pageSize": 20,
      "page": 0,
      "sortDirection": "asc",
      "sortProperty": "id",
      "title": [],
      "searchString": this.searchString
    }

    this.movies$ = this.searchString
      ? this.movieService.SearchMovies(movieParam)
      : this.movieService.GetNowPlayingMovies(movieParam);

    this.checkError(this.movies$);
  }

  writeNotification(text: string) {
    this.notification.textNotice(text);
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

  toggleSidePanel(){
    this.sidePanelOpen = !this.sidePanelOpen;
    this.drawer.toggle();
  }
}
