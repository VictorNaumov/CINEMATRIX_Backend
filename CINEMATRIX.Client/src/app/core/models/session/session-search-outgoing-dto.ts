export interface SessionSearchOutgoingDto {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  isPublic: boolean,
  startDateTime: Date,
  endDateTime: Date
}
