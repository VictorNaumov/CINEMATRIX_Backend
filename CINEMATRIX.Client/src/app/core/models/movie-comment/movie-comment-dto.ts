import { ProfileDto } from "../profile/profile-dto"

export interface MovieCommentDto {
  parentCommentId: number,
  movieId: number,
  profileId: number,
  text: string,
  dateTime: Date,
  isDeleted: boolean,
  profile: ProfileDto,
  ParentComment: MovieCommentDto,
  Replies: MovieCommentDto[]
}



