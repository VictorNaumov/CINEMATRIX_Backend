import { Component, Input, OnChanges, OnInit, Sanitizer } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { MovieFoundIncomingDto } from 'src/app/core/models/movie/movie-found-incoming-dto';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';

@Component({
  selector: 'app-movie-detail-slider',
  templateUrl: './movie-detail-slider.component.html',
  styleUrls: ['./movie-detail-slider.component.scss']
})
export class MovieDetailSliderComponent implements OnInit, OnChanges {
  slideIndex:number;

  mediaOfMovie: any[] = [];

  @Input() movie: MovieFoundIncomingDto;

  constructor(private route: ActivatedRoute,
    public notification: NotificationManager,
    public movieService: MovieService,
    public sanitizer: DomSanitizer) { }

  ngOnInit(): void {
    this.mediaOfMovie.push(...this.movie.images);
    this.mediaOfMovie.push(...this.movie.videos);

    this.currentSlide(1);
  }

  ngOnChanges(): void {
    this.currentSlide(1);
  }

  plusSlides(n: number) {
    this.showSlides(this.slideIndex += n);
  }

  currentSlide(n: number) {
    this.showSlides(this.slideIndex = n);
  }

  showSlides(n: number) {
    let i;
    let slides = document.getElementsByClassName("mySlides");
    let dots = document.getElementsByClassName("dot");

    if (!slides.length) return;


    if (n > slides.length) {
      this.slideIndex = 1
    }

    if (n < 1) {
      this.slideIndex = slides.length
    }

    for (i = 0; i < slides.length; i++) {
      (slides[i] as HTMLElement).style.display = "none";
      dots[i].className = dots[i].className.replace(" active", "");
    }

    (slides[this.slideIndex - 1] as HTMLElement).style.display = "block";
    (dots[this.slideIndex - 1] as HTMLElement).className += " active";
  }

  videoURL(n: number) {
    return this.sanitizer.bypassSecurityTrustResourceUrl('https://www.youtube.com/embed/' + this.mediaOfMovie[n].key);
  }
}
