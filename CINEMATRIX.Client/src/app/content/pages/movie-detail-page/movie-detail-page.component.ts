import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, switchMap } from 'rxjs';
import { MovieCreditsDto } from 'src/app/core/models/extends/movie-credits-dto';
import { MovieFoundIncomingDto } from 'src/app/core/models/movie/movie-found-incoming-dto';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { MovieDetailSliderComponent } from './movie-detail-slider/movie-detail-slider.component';

@Component({
  selector: 'app-movie-detail-page',
  templateUrl: './movie-detail-page.component.html',
  styleUrls: ['./movie-detail-page.component.scss']
})
export class MovieDetailPageComponent implements OnInit {
  public movie$: Observable<MovieFoundIncomingDto> | undefined;
  public movie: MovieFoundIncomingDto;
  public mainCasts: MovieCreditsDto[];

  movieId: number | undefined;

  constructor(private route: ActivatedRoute,
    public notification: NotificationManager,
    public movieService: MovieService) { }

  ngOnInit(): void {
    this.route.paramMap.pipe(switchMap(params => params.getAll('movieId')))
      .subscribe(data => this.movieId = +data);

    this.sendQuery();
  }

  public sendQuery(): void {
    this.movie$ = this.movieService.GetMovieById(this.movieId);

    this.movie$.subscribe((movie: MovieFoundIncomingDto) => {
      this.mainCasts = movie.credits
        .filter(c => c.profilePath && c.order)
        .sort((a: MovieCreditsDto, b: MovieCreditsDto) => +a.order - +b.order)
        .slice(0, 7);
    });
  }
}
