import { FavoriteMovieFoundIncomingDto } from "./favorite-movie";

export interface FavoriteMovieSearchIncomingDto {
  items: FavoriteMovieFoundIncomingDto[],
  totalCount: number
}
