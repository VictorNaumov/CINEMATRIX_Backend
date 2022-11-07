import { PersonFoundIncomingDto } from "./person-found-incoming-dto";

export interface PersonSearchIncomingDto {
  items: PersonFoundIncomingDto[],
  totalCount: number
}
