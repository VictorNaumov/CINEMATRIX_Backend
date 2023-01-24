export interface MovieCommentDto {
  parentCommentId: number,
  movieId: number,
  profileId: number,
  text: string,
  dateTime: Date,
  isDeleted: boolean,
}



