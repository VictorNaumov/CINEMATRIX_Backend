import { PersonFoundIncomingDto } from "./person-found-incoming-dto";

export interface PersonSearchIncomingDTO {
  items: PersonFoundIncomingDto[],
  totalCount: number
}
