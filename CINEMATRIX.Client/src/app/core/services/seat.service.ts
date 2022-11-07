import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { SeatDto } from "../models/seat/seat-dto";
import { SeatSearchIncomingDto } from "../models/seat/seat-search-incoming-dto";
import { SeatSearchOutgoingDto } from "../models/seat/seat-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class SeatService {
    public pathBase: string = `${connectionString}/seat`;

    constructor(private http: HttpClient) { }

    public SearchSeat(searchParameters: SeatSearchOutgoingDto): Observable<SeatSearchIncomingDto> {
        return this.http.post<SeatSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
    }

    public CreateSeat(seat: SeatDto): Observable<number> {
        return this.http.post<number>(`${this.pathBase}`, seat);
    }

    public DeleteSeat(seatId: number): Observable<any> {
        return this.http.delete<any>(`${this.pathBase}/${seatId}`);
    }

    public UpdateSeat(seatId: number, seat: SeatDto): Observable<SeatDto> {
        return this.http.put<SeatDto>(`${this.pathBase}/${seatId}`, seat);
    }

    public GetSeatById(id: number): Observable<SeatDto> {
        return this.http.get<SeatDto>(`${this.pathBase}/${id}`);
    }
}
