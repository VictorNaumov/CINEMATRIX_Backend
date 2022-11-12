import { Component, OnInit } from '@angular/core';
import { MovieSearchIncomingDto } from 'src/app/core/models/movie/movie-search-incoming-dto';
import { MovieSearchOutgoingDto } from 'src/app/core/models/movie/movie-search-outgoing-dto';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {
  public movies: MovieSearchIncomingDto;

  public isLoading: boolean = true;

  constructor(public notification: NotificationManager,
    public movieService: MovieService) { }

  ngOnInit(): void {
    this.sendQuery();
  }

  public sendQuery(): void {
    this.isLoading = true;
    var parameters: MovieSearchOutgoingDto = {
      "pageSize": 20,
      "page": 0,
      "sortDirection": "asc",
      "sortProperty": "id",
      "title": [],
      "searchString": ""
    }

    this.movieService.GetNowPlayingMovies(parameters).subscribe((data: MovieSearchIncomingDto)=> {
      this.movies = data;

      console.log(data);


      this.isLoading = false;
    });
  }

  writeNotification(text:string){
    this.notification.textNotice(text);
  }
}
