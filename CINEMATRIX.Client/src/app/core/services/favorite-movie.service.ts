import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { AuthService } from "../account/auth-service";
import { FavoriteMovieDto } from "../models/favorite-movie/favorite-movie-dto";
import { FavoriteMovieSearchIncomingDto } from "../models/favorite-movie/favorite-movie-search-incoming-dto";
import { FavoriteMovieSearchOutgoingDto } from "../models/favorite-movie/favorite-movie-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class FavoriteMovieService {
  public pathBase: string = `${connectionString}/favoriteMovie`;

  constructor(private http: HttpClient,
    private authService: AuthService) { }

  public SearchFavoriteMovie(searchParameters: FavoriteMovieSearchOutgoingDto): Observable<FavoriteMovieSearchIncomingDto> {
    return this.http.post<FavoriteMovieSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
  }

  public CreateFavoriteMovie(movieId: number): Observable<number> {
    let addFavoriteMovieParams: FavoriteMovieDto = {
      "profileId": +this.authService.profileId,
      "movieId": movieId,
      "rating": 5
    }

    return this.http.post<number>(`${this.pathBase}`, addFavoriteMovieParams);
  }

  public DeleteFavoriteMovie(favoriteMovieId: number): Observable<any> {
    return this.http.delete<any>(`${this.pathBase}/${favoriteMovieId}`);
  }

  public UpdateFavoriteMovie(favoriteMovieId: number, favoriteMovie: FavoriteMovieDto): Observable<FavoriteMovieDto> {
    return this.http.put<FavoriteMovieDto>(`${this.pathBase}/${favoriteMovieId}`, favoriteMovie);
  }

  public GetFavoriteMovieById(favoriteMovieId: number): Observable<FavoriteMovieDto> {
    return this.http.get<FavoriteMovieDto>(`${this.pathBase}/${favoriteMovieId}`);
  }
}
