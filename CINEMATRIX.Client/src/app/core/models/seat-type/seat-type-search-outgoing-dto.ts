export interface SeatTypeSearchOutgoingDTO {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  name: string[],
  startPrice: number,
  finishPrice: number,
}
