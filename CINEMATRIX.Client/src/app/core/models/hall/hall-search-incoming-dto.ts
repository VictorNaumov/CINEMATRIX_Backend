import { HallFoundIncomingDto } from "./hall-found-incoming-dto";

export interface HallSearchIncomingDTO {
  items: HallFoundIncomingDto[],
  totalCount: number
}
