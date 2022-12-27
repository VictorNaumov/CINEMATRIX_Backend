import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { MovieCommentSearchOutgoingDto } from "../models/movie-comment/movie-comment-search-outgoing-dto";
import { MovieCommentSearchIncomingDto } from "../models/movie-comment/movie-comment-search-incoming-dto";
import { MovieCommentDto } from "../models/movie-comment/movie-comment-dto";

@Injectable({ providedIn: 'root' })
export class MovieCommentService {
  public pathBase: string = `${connectionString}/movieComment`;

  constructor(private http: HttpClient) { }


  public SearchMovieComment(searchParameters: MovieCommentSearchOutgoingDto): Observable<MovieCommentSearchIncomingDto> {
    return this.http.post<MovieCommentSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
  }

  public CreateMovieComment(movieComment: MovieCommentDto): Observable<number> {
    return this.http.post<number>(`${this.pathBase}`, movieComment);
  }

  public DeleteMovieComment(movieCommentId: number): Observable<any> {
    return this.http.delete<any>(`${this.pathBase}/${movieCommentId}`);
  }

  public UpdateMovieComment(movieCommentId: number, movieComment: MovieCommentDto): Observable<MovieCommentDto> {
    return this.http.put<MovieCommentDto>(`${this.pathBase}/${movieCommentId}`, movieComment);
  }

  public GetMovieCommentById(id: number): Observable<MovieCommentDto> {
    return this.http.get<MovieCommentDto>(`${this.pathBase}/${id}`);
  }
}
