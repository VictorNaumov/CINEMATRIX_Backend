import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { SeatTypeDto } from "../models/seat-type/seat-type-dto";
import { SeatTypeSearchIncomingDto } from "../models/seat-type/seat-type-search-incoming-dto";
import { SeatTypeSearchOutgoingDto } from "../models/seat-type/seat-type-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class SeatTypeService {
    public pathBase: string = `${connectionString}/seatType`;

    constructor(private http: HttpClient) { }

    public SearchSeatType(searchParameters: SeatTypeSearchOutgoingDto): Observable<SeatTypeSearchIncomingDto> {
        return this.http.post<SeatTypeSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
    }

    public CreateSeatType(seatType: SeatTypeDto): Observable<number> {
        return this.http.post<number>(`${this.pathBase}`, seatType);
    }

    public DeleteSeatType(seatTypeId: number): Observable<any> {
        return this.http.delete<any>(`${this.pathBase}/${seatTypeId}`);
    }

    public UpdateSeatType(seatTypeId: number, seatType: SeatTypeDto): Observable<SeatTypeDto> {
        return this.http.put<SeatTypeDto>(`${this.pathBase}/${seatTypeId}`, seatType);
    }

    public GetSeatTypeById(id: number): Observable<SeatTypeDto> {
        return this.http.get<SeatTypeDto>(`${this.pathBase}/${id}`);
    }
}
