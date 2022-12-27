export interface MovieCommentSearchOutgoingDto {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  parentCommentIds: number[],
  movieIds: number[],
  profileIds: number[],
  text: string[],
  startDateTime: Date,
  endDateTime: Date,
  isDeleted: boolean
}



