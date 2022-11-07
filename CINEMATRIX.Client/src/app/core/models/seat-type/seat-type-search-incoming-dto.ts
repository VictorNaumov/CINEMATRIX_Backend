import { SeatTypeFoundIncomingDto } from "./seat-type-found-incoming-dto";

export interface SeatTypeSearchIncomingDto {
  items: SeatTypeFoundIncomingDto[],
  totalCount: number
}
