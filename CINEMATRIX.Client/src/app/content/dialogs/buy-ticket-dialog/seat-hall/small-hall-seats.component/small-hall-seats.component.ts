import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { SeatFoundIncomingDto } from 'src/app/core/models/seat/seat-found-incoming-dto';
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
  seats: SeatTableData[] = [];

  @Output() selectedSeatsEvent = new EventEmitter<SeatFoundIncomingDto[]>();

  constructor() { }

  ngOnInit(): void {
    this.initSeatTableData();
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

  toggleSeats(seat: SeatTableData) {
    if (seat.isTaken) return;
    seat.isSelected = !seat.isSelected;

    let selectedSeatIds = this.seats.filter(c => c.isSelected).map(x => x.id);
    let selectedSeats = this.session.hall.seats.filter(s => selectedSeatIds.some(id => id == s.id));

    this.selectedSeatsEvent.emit(selectedSeats);
  }
}

