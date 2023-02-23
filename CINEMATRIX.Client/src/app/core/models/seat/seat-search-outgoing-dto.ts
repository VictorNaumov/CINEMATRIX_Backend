import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface SeatSearchOutgoingDto extends PageDTOBase {
  row: number[],
  number: number[],
}
