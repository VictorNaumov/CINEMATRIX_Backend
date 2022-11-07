import { GenreFoundIncomingDto } from "./genre-found-incoming-dto";

export interface GenreSearchIncomingDTO {
  items: GenreFoundIncomingDto[],
  totalCount: number
}
