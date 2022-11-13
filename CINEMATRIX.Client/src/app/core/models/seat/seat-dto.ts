import { SeatTypeFoundIncomingDto } from "../seat-type/seat-type-found-incoming-dto";

export interface SeatDto {
  row: number,
  number: number,
  seatType: SeatTypeFoundIncomingDto
}
