import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { MovieFoundIncomingDto } from "../models/movie/movie-found-incoming-dto";
import { MovieSearchIncomingDto } from "../models/movie/movie-search-incoming-dto";
import { MovieSearchOutgoingDto } from "../models/movie/movie-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class MovieService {
  public pathBase: string = `${connectionString}/movie`;

  constructor(private http: HttpClient) { }

  public GetMovieById(id: number): Observable<MovieFoundIncomingDto> {
    return this.http.get<MovieFoundIncomingDto>(`${this.pathBase}/${id}`);
  }

  public GetSimilarMovies(searchParameters: MovieSearchOutgoingDto): Observable<MovieSearchIncomingDto> {
    return this.http.post<MovieSearchIncomingDto>(`${this.pathBase}`, searchParameters);
  }

  public GetTopRatedMovies(searchParameters: MovieSearchOutgoingDto): Observable<MovieSearchIncomingDto> {
    return this.http.post<MovieSearchIncomingDto>(`${this.pathBase}/topRated`, searchParameters);
  }

  public GetNowPlayingMovies(searchParameters: MovieSearchOutgoingDto): Observable<MovieSearchIncomingDto> {
    return this.http.post<MovieSearchIncomingDto>(`${this.pathBase}/nowPlaying`, searchParameters);
  }

  public SearchMovies(searchParameters: MovieSearchOutgoingDto): Observable<MovieFoundIncomingDto> {
    return this.http.put<MovieFoundIncomingDto>(`${this.pathBase}/search`, searchParameters);
  }
}
