import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/core/account/auth-service';
import { UserFoundIncomingDto } from 'src/app/core/models/auth/user-found-incoming-dto';
import { TicketFoundIncomingDto } from 'src/app/core/models/ticket/ticket-found-incoming-dto';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';

@Component({
  selector: 'app-profile-page',
  templateUrl: './profile-page.component.html',
  styleUrls: ['./profile-page.component.scss']
})
export class ProfilePageComponent implements OnInit {
  public user$: Observable<UserFoundIncomingDto>
  public tickets: TicketFoundIncomingDto[] = [];

  displayedColumns: string[] = ['id', 'seatId', 'sessionId'];
  dataSource = new MatTableDataSource<TicketFoundIncomingDto>(this.tickets);

  // @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    // this.dataSource.paginator = this.paginator;
  }


  constructor(public notification: NotificationManager,
    public authService: AuthService) { }

  ngOnInit(): void {
    this.sendQuery();
  }

  sendQuery() {
    this.user$ = this.authService.whoami();

    this.user$.subscribe(x => this.tickets = x.profile.tickets)
    this.user$.subscribe(x => console.log(x))
  }
}
