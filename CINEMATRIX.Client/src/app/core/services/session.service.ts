import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { SessionDto } from "../models/session/session-dto";
import { SessionSearchIncomingDto } from "../models/session/session-search-incoming-dto";
import { SessionSearchOutgoingDto } from "../models/session/session-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class SessionService {
    public pathBase: string = `${connectionString}/session`;

    constructor(private http: HttpClient) { }

    public SearchSession(searchParameters: SessionSearchOutgoingDto): Observable<SessionSearchIncomingDto> {
        return this.http.post<SessionSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
    }

    public CreateSession(Session: SessionDto): Observable<number> {
        return this.http.post<number>(`${this.pathBase}`, Session);
    }

    public DeleteSession(SessionId: number): Observable<any> {
        return this.http.delete<any>(`${this.pathBase}/${SessionId}`);
    }

    public UpdateSession(SessionId: number, Session: SessionDto): Observable<SessionDto> {
        return this.http.put<SessionDto>(`${this.pathBase}/${SessionId}`, Session);
    }

    public GetSessionById(id: number): Observable<SessionDto> {
        return this.http.get<SessionDto>(`${this.pathBase}/${id}`);
    }
}
