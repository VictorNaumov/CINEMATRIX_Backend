import { SessionFoundIncomingDto } from "./session-found-incoming-dto";

export interface SessionSearchIncomingDto {
  items: SessionFoundIncomingDto[],
  totalCount: number
}
