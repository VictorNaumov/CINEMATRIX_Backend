import { SessionFoundIncomingDto } from "../session/session-found-incoming-dto";
import { TicketDto } from "./ticket-dto";

export interface TicketFoundIncomingDto extends TicketDto {
  id: number,
  session?: SessionFoundIncomingDto
}
