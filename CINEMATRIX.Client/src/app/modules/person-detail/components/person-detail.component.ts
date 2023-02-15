import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { ActivatedRoute } from '@angular/router';
import { Observable, switchMap } from 'rxjs';
import { PersonFoundIncomingDto } from 'src/app/core/models/person/person-found-incoming-dto';
import { NotificationManager } from 'src/app/core/services/notification-manager';
import { PersonService } from 'src/app/core/services/person.service';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';

@Component({
  selector: 'app-person-detail',
  templateUrl: './person-detail.component.html',
  styleUrls: ['./person-detail.component.scss']
})
export class PersonDetailComponent implements OnInit {
  public person$: Observable<PersonFoundIncomingDto> | undefined;
  public person: PersonFoundIncomingDto;
  public personId: number;

  public isError: boolean = false;

  constructor(public notification: NotificationManager,
    public personService: PersonService,
    public route: ActivatedRoute,
    public snackBar: MatSnackBar) { }

  ngOnInit(): void {

    this.route.paramMap.pipe(switchMap(params => params.getAll('personId')))
      .subscribe(data => this.personId = +data);

    this.sendQuery();
  }

  sendQuery(): void {
    this.person$ = this.personService.GetPersonById(this.personId);

    this.person$.subscribe(a => console.log(a))

    this.checkError(this.person$);
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
