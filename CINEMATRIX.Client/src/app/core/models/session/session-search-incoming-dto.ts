import { SessionFoundIncomingDto } from "./session-found-incoming-dto";

export interface SessionSearchIncomingDTO {
  items: SessionFoundIncomingDto[],
  totalCount: number
}
