import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { SessionSearchIncomingDto } from 'src/app/core/models/session/session-search-incoming-dto';
import { SessionSearchOutgoingDto } from 'src/app/core/models/session/session-search-outgoing-dto';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { SessionService } from 'src/app/core/services/session.service';

@Component({
  selector: 'app-sessions-page',
  templateUrl: './sessions-page.component.html',
  styleUrls: ['./sessions-page.component.scss']
})
export class SessionsPageComponent implements OnInit {
  public sessions$: Observable<SessionSearchIncomingDto> | undefined;
  public isLoading: boolean = true;

  constructor(public notification: NotificationManager,
    public movieService: MovieService,
    public sessionService: SessionService) { }

  ngOnInit(): void {
    this.sendQuery();
  }

  public sendQuery(): void {
    this.isLoading = true;

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
      "endDateTime": endDateTime
    }

    this.sessions$ = this.sessionService.SearchSession(sessionsParam);
    this.sessions$.subscribe(x => console.log(x))
  }

}
