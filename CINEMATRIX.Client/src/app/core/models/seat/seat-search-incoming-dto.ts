import { SeatFoundIncomingDto } from "./seat-found-incoming-dto";

export interface SeatSearchIncomingDTO {
  items: SeatFoundIncomingDto[],
  totalCount: number
}
