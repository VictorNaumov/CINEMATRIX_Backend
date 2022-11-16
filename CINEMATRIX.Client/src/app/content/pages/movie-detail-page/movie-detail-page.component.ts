import { Component, OnInit, QueryList, ViewChildren } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { ActivatedRoute } from '@angular/router';
import { Observable, switchMap } from 'rxjs';
import { MovieCreditsDto } from 'src/app/core/models/extends/movie-credits-dto';
import { MovieFoundIncomingDto } from 'src/app/core/models/movie/movie-found-incoming-dto';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';
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

  public isError: boolean = false;


  @ViewChildren(MovieDetailSliderComponent)
  public children: QueryList<MovieDetailSliderComponent>

  private childSlider: MovieDetailSliderComponent

  public ngAfterViewInit(): void {
    this.children.changes.subscribe((comps: QueryList<MovieDetailSliderComponent>) => {
      this.childSlider = comps.first;
      this.childSlider.currentSlide(1);
    });
  }

  movieId: number | undefined;

  constructor(private route: ActivatedRoute,
    public notification: NotificationManager,
    public movieService: MovieService,
    public snackBar: MatSnackBar) { }

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
        .slice(0, 14);
    });

    this.checkError(this.movie$);
  }


  checkError(sub: Observable<any>): void {
    sub.subscribe(
      (_) => { },
      error => {
        this.isError = true;
        console.log(error);
        this.snackBar.open(errorMessage, "Close")
      })
  }
}
