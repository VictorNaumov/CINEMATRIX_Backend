import { SeatFoundIncomingDto } from "./seat-found-incoming-dto";

export interface SeatSearchIncomingDto {
  items: SeatFoundIncomingDto[],
  totalCount: number
}
