import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface GenreSearchOutgoingDto extends PageDTOBase {
  name: string[],
}
