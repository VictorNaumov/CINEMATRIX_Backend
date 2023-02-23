import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface MovieCommentSearchOutgoingDto extends PageDTOBase {
  parentCommentIds: number[],
  movieIds: number[],
  profileIds: number[],
  text: string[],
  startDateTime: Date,
  endDateTime: Date,
  isDeleted: boolean
}



