import { ProfileFoundIncomingDto } from "../profile/profile-found-incoming-dto";
import { MovieCommentDto } from "./movie-comment-dto";

export interface MovieCommentFoundIncomingDto extends MovieCommentDto {
  id: number,
  profile: ProfileFoundIncomingDto,
  parentComment: MovieCommentFoundIncomingDto,
  replies: MovieCommentFoundIncomingDto[]
}
