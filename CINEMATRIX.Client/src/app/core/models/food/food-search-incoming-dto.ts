import { FoodFoundIncomingDto } from "./food-found-incoming-dto";

export interface FoodSearchIncomingDto {
  items: FoodFoundIncomingDto[],
  totalCount: number
}
