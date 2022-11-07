import { HallFoundIncomingDto } from "./hall-found-incoming-dto";

export interface HallSearchIncomingDto {
  items: HallFoundIncomingDto[],
  totalCount: number
}
