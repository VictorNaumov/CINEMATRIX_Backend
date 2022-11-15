import { Component, OnInit } from '@angular/core';
import { forkJoin, Observable } from 'rxjs';
import { GenreSearchIncomingDto } from 'src/app/core/models/genre/genre-search-incoming-dto';
import { GenreSearchOutgoingDto } from 'src/app/core/models/genre/genre-search-outgoing-dto';
import { MovieSearchIncomingDto } from 'src/app/core/models/movie/movie-search-incoming-dto';
import { MovieSearchOutgoingDto } from 'src/app/core/models/movie/movie-search-outgoing-dto';
import { GenreService } from 'src/app/core/services/genre.service';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';

@Component({
  selector: 'app-movies-page',
  templateUrl: './movies-page.component.html',
  styleUrls: ['./movies-page.component.scss']
})
export class MoviesPageComponent implements OnInit {
  public movies$: Observable<MovieSearchIncomingDto> | undefined;
  public genres$: Observable<GenreSearchIncomingDto> | undefined;

  public isLoading: boolean = true;

  searchString: string = '';

  constructor(public notification: NotificationManager,
    public movieService: MovieService,
    public genreService: GenreService) { }

  ngOnInit(): void {
    this.sendQuery();
  }

  public sendQuery(): void {
    this.isLoading = true;
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

    this.movies$.subscribe(x => console.log(x))
    this.genres$ = this.genreService.SearchGenre(genreParam);
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

  }

  writeNotification(text: string) {
    this.notification.textNotice(text);
  }
}
