import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { groupBy, mergeMap, Observable, pipe } from 'rxjs';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';

@Component({
  selector: 'app-management-page',
  templateUrl: './management-page.component.html',
  styleUrls: ['./management-page.component.scss']
})
export class managementPageComponent implements OnInit {
  public isError: boolean = false;
  public query$: Observable<any> | undefined;

  constructor() { }

  ngOnInit() {
    this.sendManagementQuery();
  }

  sendManagementQuery() {
    let startDateTime: Date = new Date();
    startDateTime.setFullYear(2001, 12, 10);

    let endDateTime: Date = new Date();
    endDateTime.setFullYear(2025, 12, 10);

    // this.checkError(this.query$);
  }

}
