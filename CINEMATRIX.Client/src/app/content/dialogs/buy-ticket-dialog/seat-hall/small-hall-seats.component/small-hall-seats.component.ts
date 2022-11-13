import { Component, Input, OnInit } from '@angular/core';
import { SessionFoundIncomingDto } from 'src/app/core/models/session/session-found-incoming-dto';
import { TicketFoundIncomingDto } from 'src/app/core/models/ticket/ticket-found-incoming-dto';

export interface SeatTableData {
  id: number;
  row: number;
  number: number;
  seatTypeName: string;
  seatTypePrice: number;
  isTaken: boolean;
  isSelected: boolean;
}

@Component({
  selector: 'app-small-hall-seats',
  templateUrl: './small-hall-seats.component.html',
  styleUrls: ['./small-hall-seats.component.scss']
})
export class SmallHallSeatsComponent implements OnInit {

  @Input() session: SessionFoundIncomingDto;
  tickets: TicketFoundIncomingDto[];

  seats: SeatTableData[] = [];

  displayedColumns: number[] = [];

  constructor() {
  }

  ngOnInit(): void {
    this.tickets = this.session.tickets;

    this.displayedColumns = [...new Set(this.seats.map(seat => seat.number))];

   this.initSeatTableData();

   console.log('this.seats', this.seats);
  }

  initSeatTableData() {
    this.session.hall.seats.forEach(seat => {
      this.seats.push({
        "id": seat.id,
        "row": seat.row,
        "number": seat.number,
        "seatTypeName": seat.seatType.name,
        "seatTypePrice": seat.seatType.price,
        "isTaken": this.session.tickets.some(ticket => ticket.seatId == seat.id),
        "isSelected": false
      })
    });
  }
}

