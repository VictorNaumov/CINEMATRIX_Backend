import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface FavoriteMovieSearchOutgoingDto extends PageDTOBase {
  profileIds: number[];
  movieIds: number[];
  ratings: number[];
}
