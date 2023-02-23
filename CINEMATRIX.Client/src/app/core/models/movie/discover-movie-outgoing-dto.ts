import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface DiscoverMovieOutgoingDto extends PageDTOBase {
  genres: number[],
  people: number[],
  includeAdult?: boolean,
  releaseDateGTE?: Date,
  releaseDateLTE?: Date,
}
