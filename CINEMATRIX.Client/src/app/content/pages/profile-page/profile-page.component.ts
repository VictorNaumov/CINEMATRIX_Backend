import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatSnackBar, MatSnackBarRef, MatTableDataSource } from '@angular/material';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/core/account/auth-service';
import { UserFoundIncomingDto } from 'src/app/core/models/auth/user-found-incoming-dto';
import { ProfileFoundIncomingDto } from 'src/app/core/models/profile/profile-found-incoming-dto';
import { TicketFoundIncomingDto } from 'src/app/core/models/ticket/ticket-found-incoming-dto';
import { MovieService } from 'src/app/core/services/movie.service';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { TicketService } from 'src/app/core/services/ticket.service';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';

@Component({
  selector: 'app-profile-page',
  templateUrl: './profile-page.component.html',
  styleUrls: ['./profile-page.component.scss']
})
export class ProfilePageComponent implements OnInit {
  public user$: Observable<UserFoundIncomingDto>
  public tickets: TicketFoundIncomingDto[] = [];

  public isError: boolean = false;

  displayedColumns: string[] = ['id', 'ticketId', 'seatType', 'seat', 'sessionId', 'date', 'hall', 'movieId', 'goToMovie'];
  dataSource: any;

  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(public notification: NotificationManager,
    public authService: AuthService,
    public ticketService: TicketService,
    public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.sendQuery();
  }

  sendQuery() {
    this.user$ = this.authService.whoami();
    this.checkError(this.user$);

    this.user$.subscribe((user: UserFoundIncomingDto) => {
      let tickets$ = this.ticketService.GetByProfileId(user.profile.id);

      tickets$.subscribe((tickets: TicketFoundIncomingDto[]) => {
        this.tickets = tickets;
        this.dataSource = new MatTableDataSource<TicketFoundIncomingDto>(this.tickets);
        this.paginator.pageSize = 10;
        this.dataSource.paginator = this.paginator;
      })

      this.checkError(tickets$);
    })

    this.user$.subscribe(x => console.log(x))
  }

  checkError(sub: Observable<any>): void {
    sub.subscribe(
      (_) => { },
      error => {
        this.isError = true;
        console.log(error);
        this.snackBar.open(errorMessage, "Close")
      })
  }
}
