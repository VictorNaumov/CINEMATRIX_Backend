import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface SeatTypeSearchOutgoingDto extends PageDTOBase {
  name: string[],
  startPrice: number,
  finishPrice: number,
}
