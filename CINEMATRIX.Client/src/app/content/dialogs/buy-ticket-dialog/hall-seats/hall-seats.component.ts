import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { SeatFoundIncomingDto } from 'src/app/core/models/seat/seat-found-incoming-dto';
import { SessionFoundIncomingDto } from 'src/app/core/models/session/session-found-incoming-dto';

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
  selector: 'app-hall-seats',
  templateUrl: './hall-seats.component.html',
  styleUrls: ['./hall-seats.component.scss']
})
export class HallSeatsComponent implements OnInit {
  @Input() session: SessionFoundIncomingDto;
  seats: SeatTableData[] = [];

  public columnsCount: number;

  @Output() selectedSeatsEvent = new EventEmitter<SeatFoundIncomingDto[]>();

  constructor() { }

  ngOnInit(): void {
    this.initSeatTableData();
  }

  initSeatTableData() {
    this.session.hall.seats.forEach(seat => {
      console.log(this.session.tickets);

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

    this.columnsCount = Math.max(...this.seats.map(s => s.number))

    if(this.seats.every(s => s.seatTypeName == "Romantic")){
      this.columnsCount *= 2;
    }
  }

  toggleSeats(seat: SeatTableData) {
    if (seat.isTaken) return;
    seat.isSelected = !seat.isSelected;

    let selectedSeatIds = this.seats.filter(c => c.isSelected).map(x => x.id);
    let selectedSeats = this.session.hall.seats.filter(s => selectedSeatIds.some(id => id == s.id));

    this.selectedSeatsEvent.emit(selectedSeats);
  }
}

