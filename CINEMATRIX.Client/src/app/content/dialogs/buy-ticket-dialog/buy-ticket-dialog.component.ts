import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MatSnackBar, MAT_DIALOG_DATA } from '@angular/material';
import { AuthService } from 'src/app/core/account/auth-service';
import { SeatFoundIncomingDto } from 'src/app/core/models/seat/seat-found-incoming-dto';
import { SessionFoundIncomingDto } from 'src/app/core/models/session/session-found-incoming-dto';
import { TicketFoundIncomingDto } from 'src/app/core/models/ticket/ticket-found-incoming-dto';
import { TicketService } from 'src/app/core/services/ticket.service';

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
  selectedSeats: SeatFoundIncomingDto[] = [];
  sumPrice: number = 0;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data: BuyTicketDialogData,
    public dialogRef: MatDialogRef<BuyTicketDialog>,
    public snackBar: MatSnackBar,
    public authService: AuthService,
    public ticketService: TicketService
  ) {
    this.session = data.session;
  }

  ngOnInit(): void { }

  onNoClick(): void {
    this.dialogRef.close();
  }


  onOkClick(): void {
    if (!this.authService.isAuthenticated()) {
      this.snackBar.open("You need authorize for book seat.", "Close");
      return;
    }

    this.dialogRef.close(this.selectedSeats);
  }


  setSelectedSeats(selectedSeats: SeatFoundIncomingDto[]): void {
    this.selectedSeats = selectedSeats;
    this.sumPrice = this.selectedSeats.length
      ? this.selectedSeats
        .map(x => x.seatType.price)
        .reduce((sum, current) => sum + current)
      : 0;
  }
}
