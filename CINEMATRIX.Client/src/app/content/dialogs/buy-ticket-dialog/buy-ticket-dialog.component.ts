import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { SessionFoundIncomingDto } from 'src/app/core/models/session/session-found-incoming-dto';

export interface BuyTicketDialogData {
  session: SessionFoundIncomingDto;
}

@Component({
  selector: 'app-buy-ticket-dialog',
  templateUrl: './buy-ticket-dialog.component.html',
  styleUrls: ['./buy-ticket-dialog.component.scss']
})
export class BuyTicketDialog implements OnInit {
  session: SessionFoundIncomingDto;

  constructor(
    public dialogRef: MatDialogRef<BuyTicketDialog>,
    @Inject(MAT_DIALOG_DATA) public data: BuyTicketDialogData
  ) {
    this.session = data.session;
    console.log((this.session));

  }

  ngOnInit(): void {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
