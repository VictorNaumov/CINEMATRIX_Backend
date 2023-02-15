import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatSnackBar, MatSnackBarRef, MatTableDataSource } from '@angular/material';
import { ActivatedRoute } from '@angular/router';
import { Observable, switchMap } from 'rxjs';
import { AuthService } from 'src/app/core/account/auth-service';
import { UserFoundIncomingDto } from 'src/app/core/models/auth/user-found-incoming-dto';
import { ProfileFoundIncomingDto } from 'src/app/core/models/profile/profile-found-incoming-dto';
import { TicketFoundIncomingDto } from 'src/app/core/models/ticket/ticket-found-incoming-dto';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { ProfileService } from 'src/app/core/services/profile.service';
import { TicketService } from 'src/app/core/services/ticket.service';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  public user$: Observable<UserFoundIncomingDto>
  public profile$: Observable<ProfileFoundIncomingDto>
  public tickets: TicketFoundIncomingDto[] = [];
  public profileId: number;

  public isError: boolean = false;

  constructor(
    public route: ActivatedRoute,
    public notification: NotificationManager,
    public authService: AuthService,
    public profileService: ProfileService,
    public ticketService: TicketService,
    public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.route.paramMap.pipe(switchMap(params => params.getAll('profileId')))
      .subscribe(data => {
        this.profileId = +data;
        this.sendQuery();
      });
  }

  sendQuery() {
    if (+this.authService.profileId == this.profileId) {
      this.user$ = this.authService.whoami();
      this.checkError(this.user$);
    }

    this.profile$ = this.profileService.GetProfileById(this.profileId);

    this.profile$.subscribe((profile: ProfileFoundIncomingDto) => {
      this.tickets = profile.tickets;
      console.log(profile)
    })

    this.checkError(this.profile$);
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
