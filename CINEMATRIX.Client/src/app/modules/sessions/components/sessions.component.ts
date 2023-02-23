import { Component, OnInit } from '@angular/core';
import { MatDialog, MatSnackBar } from '@angular/material';
import { forkJoin, Observable } from 'rxjs';
import { BuyTicketDialog } from 'src/app/content/dialogs/buy-ticket-dialog/buy-ticket-dialog.component';
import { HallSearchIncomingDto } from 'src/app/core/models/hall/hall-search-incoming-dto';
import { HallSearchOutgoingDto } from 'src/app/core/models/hall/hall-search-outgoing-dto';
import { SeatTypeSearchIncomingDto } from 'src/app/core/models/seat-type/seat-type-search-incoming-dto';
import { SeatTypeSearchOutgoingDto } from 'src/app/core/models/seat-type/seat-type-search-outgoing-dto';
import { SeatFoundIncomingDto } from 'src/app/core/models/seat/seat-found-incoming-dto';
import { SessionFoundIncomingDto } from 'src/app/core/models/session/session-found-incoming-dto';
import { SessionSearchIncomingDto } from 'src/app/core/models/session/session-search-incoming-dto';
import { SessionSearchOutgoingDto } from 'src/app/core/models/session/session-search-outgoing-dto';
import { TicketDto } from 'src/app/core/models/ticket/ticket-dto';
import { TicketFoundIncomingDto } from 'src/app/core/models/ticket/ticket-found-incoming-dto';
import { HallService } from 'src/app/core/services/hall.service';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { SeatTypeService } from 'src/app/core/services/seat-type.service';
import { SessionService } from 'src/app/core/services/session.service';
import { TicketService } from 'src/app/core/services/ticket.service';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';

@Component({
  selector: 'app-sessions',
  templateUrl: './sessions.component.html',
  styleUrls: ['./sessions.component.scss']
})
export class SessionsComponent implements OnInit {
  public sessions$: Observable<SessionSearchIncomingDto> | undefined;
  public halls$: Observable<HallSearchIncomingDto> | undefined;
  public seatTypes$: Observable<SeatTypeSearchIncomingDto> | undefined;

  public isError: boolean = false;

  public promoSession: SessionFoundIncomingDto;

  public weekDates: Date[] = [];
  public selectedDate: Date;

  public selectedHalls: number[] = [];
  public selectedSeats: number[] = [];
  public selectedTime: number[] = [];

  constructor(public notification: NotificationManager,
    public movieService: MovieService,
    public sessionService: SessionService,
    public hallService: HallService,
    public seatTypeService: SeatTypeService,
    public ticketService: TicketService,
    public snackBar: MatSnackBar,
    public dialog: MatDialog) { }

  ngOnInit(): void {
    this.sendQuery();
    this.initWeekDates();
  }

  public sendQuery(): void {

    this.sendSessionQuery();

    let hallsParam: HallSearchOutgoingDto = {
      "pageSize": 20,
      "name": [],
      "description": [],
      "soundSystem": [],
      "projector": [],
      "screen": [],
      "screenResolution": []
    }

    this.halls$ = this.hallService.SearchHall(hallsParam);
    this.checkError(this.halls$);

    let seatTypesParam: SeatTypeSearchOutgoingDto = {
      "pageSize": 20,
      "name": [],
      "startPrice": 0,
      "finishPrice": 100,
    }

    this.seatTypes$ = this.seatTypeService.SearchSeatType(seatTypesParam);
    this.checkError(this.seatTypes$);
  }

  sendSessionQuery() {
    let startDateTime: Date = new Date();
    startDateTime.setFullYear(2001, 12, 10);

    let endDateTime: Date = new Date();
    endDateTime.setFullYear(2025, 12, 10);

    let sessionsParam: SessionSearchOutgoingDto = {
      "pageSize": 20,
      "isPublic": true,
      "startDateTime": this.selectedDate ? this.selectedDate : startDateTime,
      "endDateTime": this.selectedDate ? this.selectedDate : endDateTime,
      "hallIds": this.selectedHalls,
      "movieIds": [],
      "seatTypeIds": this.selectedSeats,
      "timeSessions": this.selectedTime,
      "needLoadHall": true,
      "needLoadSeats": true,
      "needLoadSeatType": true
    }

    this.sessions$ = this.sessionService.SearchSession(sessionsParam);
    this.sessions$.subscribe(x => this.promoSession = x.items[5]);

    this.checkError(this.sessions$);
  }

  initWeekDates() {
    for (let i = 0; i < 7; i++) {
      this.weekDates[i] = new Date();
      this.weekDates[i].setDate(this.weekDates[i].getDate() + i);
    }
  }

  setSelectedDate(date: Date) {
    if (this.selectedDate == date) return;

    this.selectedDate = date;
    this.sendSessionQuery();
  }

  openBuyTicketDialog(session: SessionFoundIncomingDto) {

    this.ticketService.GetBySessionId(session.id).subscribe(
      (tickets: TicketFoundIncomingDto[]) => {
        session.tickets = tickets;

        const dialogRef = this.dialog.open(BuyTicketDialog, {
          data: { session: session },
        });

        dialogRef.afterClosed().subscribe((selectedSeats: SeatFoundIncomingDto[]) => {
          if (!selectedSeats || !selectedSeats.length) return;

          forkJoin(selectedSeats.map(seat => {
            let ticket: TicketDto = {
              "sessionId": session.id,
              "seatId": seat.id
            }

            return this.ticketService.CreateTicket(ticket);
          }))
            .subscribe(_ => {

              selectedSeats.forEach(seat => {
                session.tickets.push({
                  "id": undefined,
                  "sessionId": session.id,
                  "seatId": seat.id
                });
              });

              this.snackBar.open("It's booked, thank you!.", "Close")
            },
              error => {
                this.isError = true;
                console.log(error);
                this.snackBar.open(errorMessage, "Close")
              });
        });
      });
  }

  checkError(sub: Observable<any>): void {
    sub.subscribe(
      (_) => { console.log(_) },
      error => {
        this.isError = true;
        this.snackBar.open(errorMessage, "Close")
      })
  }
}
