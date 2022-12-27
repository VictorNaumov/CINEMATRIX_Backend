import { MovieCommentFoundIncomingDto } from "./movie-comment-found-incoming-dto";

export interface MovieCommentSearchIncomingDto {
  items: MovieCommentFoundIncomingDto[],
  totalCount: number
}
