import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface PersonSearchOutgoingDto extends PageDTOBase {
  name: string[],
}
