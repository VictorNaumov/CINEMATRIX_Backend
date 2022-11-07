import { GenreFoundIncomingDto } from "./genre-found-incoming-dto";

export interface GenreSearchIncomingDto {
  items: GenreFoundIncomingDto[],
  totalCount: number
}
