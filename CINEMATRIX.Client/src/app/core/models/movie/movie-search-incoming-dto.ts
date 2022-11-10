import { MovieFoundIncomingDto } from "./movie-found-incoming-dto";

export interface MovieSearchIncomingDto {
  items: MovieFoundIncomingDto[],
  totalCount: number
}
