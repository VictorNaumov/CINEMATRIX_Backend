import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface SessionSearchOutgoingDto extends PageDTOBase {
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


