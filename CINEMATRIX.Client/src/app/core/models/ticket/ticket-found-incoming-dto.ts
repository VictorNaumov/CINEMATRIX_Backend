import { ProfileFoundIncomingDto } from "../profile/profile-found-incoming-dto";
import { SeatFoundIncomingDto } from "../seat/seat-found-incoming-dto";
import { SessionFoundIncomingDto } from "../session/session-found-incoming-dto";
import { TicketDto } from "./ticket-dto";

export interface TicketFoundIncomingDto extends TicketDto {
  id: number,
  seat?: SeatFoundIncomingDto,
  session?: SessionFoundIncomingDto,
  profile?: ProfileFoundIncomingDto,
}
