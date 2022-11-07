import { FoodFoundIncomingDto } from "./food-found-incoming-dto";

export interface FoodSearchIncomingDTO {
  items: FoodFoundIncomingDto[],
  totalCount: number
}
