import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { GenreFoundIncomingDto } from "../models/genre/genre-found-incoming-dto";
import { GenreSearchIncomingDto } from "../models/genre/genre-search-incoming-dto";
import { GenreSearchOutgoingDto } from "../models/genre/genre-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class GenreService {
    public pathBase: string = `${connectionString}/Genre`;

    constructor(private http: HttpClient) { }

    public SearchGenre(searchParameters: GenreSearchOutgoingDto): Observable<GenreSearchIncomingDto> {
        return this.http.post<GenreSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
    }

    public GetGenreById(id: number): Observable<GenreFoundIncomingDto> {
        return this.http.get<GenreFoundIncomingDto>(`${this.pathBase}/${id}`);
    }
}
