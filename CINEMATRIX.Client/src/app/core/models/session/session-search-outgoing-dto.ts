export interface SessionSearchOutgoingDto {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  isPublic: boolean,
  startDateTime: Date,
  endDateTime: Date
  hallIds: number[],
  movieIds: number[],
  seatTypeIds: number[],
  timeSessions: number[],
  needLoadHall: boolean,
  needLoadSeats: boolean,
  needLoadSeatType: boolean,
}


