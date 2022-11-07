import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { TicketDto } from "../models/ticket/ticket-dto";

@Injectable({ providedIn: 'root' })
export class TicketService {
    public pathBase: string = `${connectionString}/Ticket`;

    constructor(private http: HttpClient) { }

    public CreateTicket(ticket: TicketDto): Observable<number> {
        return this.http.post<number>(`${this.pathBase}`, ticket);
    }

    public DeleteTicket(ticketId: number): Observable<any> {
        return this.http.delete<any>(`${this.pathBase}/${ticketId}`);
    }

    public UpdateTicket(ticketId: number, ticket: TicketDto): Observable<TicketDto> {
        return this.http.put<TicketDto>(`${this.pathBase}/${ticketId}`, ticket);
    }

    public GetTicketById(ticketId: number): Observable<TicketDto> {
        return this.http.get<TicketDto>(`${this.pathBase}/${ticketId}`);
    }

    public GetBySessionId(sessionId: number): Observable<TicketDto> {
        return this.http.get<TicketDto>(`${this.pathBase}/getBySessionId/${sessionId}`);
    }
}
