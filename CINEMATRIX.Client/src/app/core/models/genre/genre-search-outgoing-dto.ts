export interface FoodSearchOutgoingDTO {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  name: string[],
}
