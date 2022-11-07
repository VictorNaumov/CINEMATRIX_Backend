export interface SessionSearchOutgoingDTO {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  name: string[],
  description: string[],
  startPrice: number,
  finishPrice: number
}
