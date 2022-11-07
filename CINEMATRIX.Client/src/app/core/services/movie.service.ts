import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { MovieIncomingDto } from "../models/movie/movie-incoming-dto";
import { MovieSearchOutgoingDto } from "../models/movie/movie-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class MovieService {
  public pathBase: string = `${connectionString}/movie`;

  constructor(private http: HttpClient) { }

  public GetMovieById(id: number): Observable<MovieIncomingDto> {
    return this.http.get<MovieIncomingDto>(`${this.pathBase}/${id}`);
  }

  public GetSimilarMovies(searchParameters: MovieSearchOutgoingDto): Observable<MovieIncomingDto> {
      return this.http.post<MovieIncomingDto>(`${this.pathBase}`, searchParameters);
  }

  public GetTopRatedMovies(searchParameters: MovieSearchOutgoingDto): Observable<MovieIncomingDto> {
      return this.http.post<MovieIncomingDto>(`${this.pathBase}`, searchParameters);
  }

  public GetNowPlayingMovies(searchParameters: MovieSearchOutgoingDto): Observable<MovieIncomingDto> {
      return this.http.post<MovieIncomingDto>(`${this.pathBase}`, searchParameters);
  }

  public SearchMovies(searchParameters: MovieSearchOutgoingDto): Observable<MovieIncomingDto> {
      return this.http.put<MovieIncomingDto>(`${this.pathBase}/search`, searchParameters);
  }
}
