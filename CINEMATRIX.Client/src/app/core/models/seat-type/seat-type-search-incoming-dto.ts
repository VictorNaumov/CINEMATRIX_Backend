import { SeatTypeFoundIncomingDto } from "./seat-type-found-incoming-dto";

export interface SeatTypeSearchIncomingDTO {
  items: SeatTypeFoundIncomingDto[],
  totalCount: number
}
