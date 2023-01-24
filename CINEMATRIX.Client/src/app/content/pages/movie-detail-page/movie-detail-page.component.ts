import { Component, OnInit, QueryList, ViewChildren } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material';
import { ActivatedRoute, Router } from '@angular/router';
import { forkJoin, Observable, switchMap } from 'rxjs';
import { MovieCreditsDto } from 'src/app/core/models/extends/movie-credits-dto';
import { MovieCommentFoundIncomingDto } from 'src/app/core/models/movie-comment/movie-comment-found-incoming-dto';
import { MovieCommentDto } from 'src/app/core/models/movie-comment/movie-comment-dto';
import { MovieFoundIncomingDto } from 'src/app/core/models/movie/movie-found-incoming-dto';
import { MovieCommentService } from 'src/app/core/services/movie-comment.service';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';
import { MovieDetailSliderComponent } from './movie-detail-slider/movie-detail-slider.component';
import { AuthService } from 'src/app/core/account/auth-service';

@Component({
  selector: 'app-movie-detail-page',
  templateUrl: './movie-detail-page.component.html',
  styleUrls: ['./movie-detail-page.component.scss']
})
export class MovieDetailPageComponent implements OnInit {
  public movie$: Observable<MovieFoundIncomingDto> | undefined;
  public movie: MovieFoundIncomingDto;
  public mainCasts: MovieCreditsDto[];

  public movieComments$: Observable<MovieCommentFoundIncomingDto[]> | undefined;
  public movieComments: MovieCommentFoundIncomingDto[];

  public commentForm: FormGroup

  public isError: boolean = false;
  public isCommentControlLoading: boolean = false;

  @ViewChildren(MovieDetailSliderComponent)
  public childrenSlider: QueryList<MovieDetailSliderComponent>

  private childSlider: MovieDetailSliderComponent

  public ngAfterViewInit(): void {
    this.childrenSlider.changes.subscribe((comps: QueryList<MovieDetailSliderComponent>) => {
      this.childSlider = comps.first;
      this.childSlider.currentSlide(1);
    });
  }

  movieId: number | undefined;

  constructor(public route: ActivatedRoute,
    public notification: NotificationManager,
    public movieService: MovieService,
    public movieCommentService: MovieCommentService,
    public authService: AuthService,
    public fb: FormBuilder,
    public snackBar: MatSnackBar,
    public router: Router) { }

  ngOnInit(): void {
    this.commentForm = this.fb.group({
      text: ['', [Validators.required, Validators.maxLength(1000)]],
    });

    this.route.paramMap.pipe(switchMap(params => params.getAll('movieId')))
      .subscribe(data => this.movieId = +data);

    this.sendQuery();
  }

  sendQuery(): void {
    this.movie$ = this.movieService.GetMovieById(this.movieId);
    this.movieComments$ = this.movieCommentService.GetMovieCommentsByMovieId(this.movieId);

    forkJoin(this.movie$, this.movieComments$)
      .subscribe(([movie, movieComments]) => {
        this.movieComments = movieComments;
        this.mainCasts = movie.credits
          .filter(c => c.profilePath && c.order)
          .sort((a: MovieCreditsDto, b: MovieCreditsDto) => +a.order - +b.order)
          .slice(0, 14);
      });

    this.checkError(this.movie$);
    this.checkError(this.movieComments$);
  }


  addComment(): void {
    if (this.commentForm.valid) {
      this.isCommentControlLoading = true;
      const movieComment: MovieCommentDto = {
        parentCommentId: null,
        profileId: +this.authService.profileId,
        movieId: this.movieId,
        text: this.commentForm.value.text,
        dateTime: new Date(),
        isDeleted: false,
      };

      this.movieCommentService.CreateMovieComment(movieComment).subscribe((commentId) => {
        if (commentId > -1) {
          this.movieComments.push(this.convertMovieCommentDtoToIncomingDto(movieComment, commentId));
          this.commentForm.reset();
        }

      }, (error) => {
        this.snackBar.open(error.message, "Close")
      }, () => {
        this.isCommentControlLoading = false;
      });
    }
  }

  convertMovieCommentDtoToIncomingDto(movieComment: MovieCommentDto, id: number): MovieCommentFoundIncomingDto {
    const resultDto: MovieCommentFoundIncomingDto = {
      id: id,
      parentCommentId: null,
      profileId: movieComment.profileId,
      movieId: movieComment.movieId,
      text: movieComment.text,
      dateTime: movieComment.dateTime,
      isDeleted: movieComment.isDeleted,
      profile: null,
      ParentComment: null,
      Replies: []
    };

    return resultDto;
  }

  redirectToPerson(personId: number) {
    this.router.navigate(['/personDetails/' + personId]);
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
