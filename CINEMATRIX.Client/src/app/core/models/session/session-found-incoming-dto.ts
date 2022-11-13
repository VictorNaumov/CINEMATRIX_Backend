import { HallFoundIncomingDto } from "../hall/hall-found-incoming-dto";
import { MovieFoundIncomingDto } from "../movie/movie-found-incoming-dto";
import { TicketFoundIncomingDto } from "../ticket/ticket-found-incoming-dto";
import { SessionDto } from "./session-dto";

export interface SessionFoundIncomingDto extends SessionDto {
  id: number,
  isPublic: boolean,
  hallId: number,
  hall: HallFoundIncomingDto,
  movieId: number,
  movie: MovieFoundIncomingDto,
  dateTime: Date,
  tickets: TicketFoundIncomingDto[]
}
