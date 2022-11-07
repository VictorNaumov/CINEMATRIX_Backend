import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { HallDto } from "../models/hall/hall-dto";
import { HallSearchIncomingDto } from "../models/hall/hall-search-incoming-dto";
import { HallSearchOutgoingDto } from "../models/hall/hall-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class HallService {
    public pathBase: string = `${connectionString}/Hall`;

    constructor(private http: HttpClient) { }

    public SearchHall(searchParameters: HallSearchOutgoingDto): Observable<HallSearchIncomingDto> {
        return this.http.post<HallSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
    }

    public CreateHall(Hall: HallDto): Observable<number> {
        return this.http.post<number>(`${this.pathBase}`, Hall);
    }

    public DeleteHall(HallId: number): Observable<any> {
        return this.http.delete<any>(`${this.pathBase}/${HallId}`);
    }

    public UpdateHall(HallId: number, Hall: HallDto): Observable<HallDto> {
        return this.http.put<HallDto>(`${this.pathBase}/${HallId}`, Hall);
    }

    public GetHallById(id: number): Observable<HallDto> {
        return this.http.get<HallDto>(`${this.pathBase}/${id}`);
    }
}
