import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { Observable } from 'rxjs';
import { HallSearchIncomingDto } from 'src/app/core/models/hall/hall-search-incoming-dto';
import { HallSearchOutgoingDto } from 'src/app/core/models/hall/hall-search-outgoing-dto';
import { MovieFoundIncomingDto } from 'src/app/core/models/movie/movie-found-incoming-dto';
import { SeatTypeSearchIncomingDto } from 'src/app/core/models/seat-type/seat-type-search-incoming-dto';
import { SeatTypeSearchOutgoingDto } from 'src/app/core/models/seat-type/seat-type-search-outgoing-dto';
import { SessionFoundIncomingDto } from 'src/app/core/models/session/session-found-incoming-dto';
import { SessionSearchIncomingDto } from 'src/app/core/models/session/session-search-incoming-dto';
import { SessionSearchOutgoingDto } from 'src/app/core/models/session/session-search-outgoing-dto';
import { HallService } from 'src/app/core/services/hall.service';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { SeatTypeService } from 'src/app/core/services/seat-type.service';
import { SessionService } from 'src/app/core/services/session.service';
import { BuyTicketDialog } from '../../dialogs/buy-ticket-dialog/buy-ticket-dialog.component';

@Component({
  selector: 'app-sessions-page',
  templateUrl: './sessions-page.component.html',
  styleUrls: ['./sessions-page.component.scss']
})
export class SessionsPageComponent implements OnInit {
  public sessions$: Observable<SessionSearchIncomingDto> | undefined;
  public halls$: Observable<HallSearchIncomingDto> | undefined;
  public seatTypes$: Observable<SeatTypeSearchIncomingDto> | undefined;

  public promoSession: SessionFoundIncomingDto;

  public weekDates: Date[] = [];
  public selectedDate: Date;

  constructor(public notification: NotificationManager,
    public movieService: MovieService,
    public sessionService: SessionService,
    public hallService: HallService,
    public seatTypeService: SeatTypeService,
    public dialog: MatDialog) { }

  ngOnInit(): void {
    this.sendQuery();
    this.initWeekDates();
  }

  public sendQuery(): void {
    let startDateTime: Date = new Date();
    startDateTime.setFullYear(2001, 12, 10);

    let endDateTime: Date = new Date();
    endDateTime.setFullYear(2025, 12, 10);

    var sessionsParam: SessionSearchOutgoingDto = {
      "pageSize": 20,
      "page": 0,
      "sortDirection": "asc",
      "sortProperty": "id",
      "isPublic": true,
      "startDateTime": startDateTime,
      "endDateTime": endDateTime,
      "hallIds": [],
      "seatTypeIds": [],
      "timeSessions": [],
    }

    this.sessions$ = this.sessionService.SearchSession(sessionsParam);
    this.sessions$.subscribe(x => this.promoSession = x.items[2]);



    var hallsParam: HallSearchOutgoingDto = {
      "pageSize": 20,
      "page": 0,
      "sortDirection": "asc",
      "sortProperty": "id",
      "name": [],
      "description": [],
      "soundSystem": [],
      "projector": [],
      "screen": [],
      "screenResolution": []
    }
    this.halls$ = this.hallService.SearchHall(hallsParam);

    var seatTypesParam: SeatTypeSearchOutgoingDto = {
      "pageSize": 20,
      "page": 0,
      "sortDirection": "asc",
      "sortProperty": "id",
      "name": [],
      "startPrice": 0,
      "finishPrice": 100,
    }

    this.seatTypes$ = this.seatTypeService.SearchSeatType(seatTypesParam);
  }

  initWeekDates() {
    for (let i = 0; i < 7; i++) {
      this.weekDates[i] = new Date();
      this.weekDates[i].setDate(this.weekDates[i].getDate() + i);
    }
  }

  setSelectedDate(date: Date) {
    this.selectedDate = date;
    this.updateSessions();
  }

  updateSessions() {
    var sessionsParam: SessionSearchOutgoingDto = {
      "pageSize": 20,
      "page": 0,
      "sortDirection": "asc",
      "sortProperty": "id",
      "isPublic": true,
      "startDateTime": new Date(),
      "endDateTime": new Date(),
      "hallIds": [],
      "seatTypeIds": [],
      "timeSessions": [],
    }

    this.sessions$ = this.sessionService.SearchSession(sessionsParam);
    this.sessions$.subscribe(x => console.log(x));
  }

  openBuyTicketDialog(session: SessionFoundIncomingDto){
    const dialogRef = this.dialog.open(BuyTicketDialog, {
      data: {name: "Vasya", session: session},
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
}
