import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface FoodSearchOutgoingDto extends PageDTOBase {
  name: string[],
  description: string[],
  startPrice: number,
  finishPrice: number
}
