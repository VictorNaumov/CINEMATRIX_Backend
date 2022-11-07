export interface SeatTypeSearchOutgoingDto {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  name: string[],
  startPrice: number,
  finishPrice: number,
}
