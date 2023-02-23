import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface MovieSearchOutgoingDto extends PageDTOBase {
  title: string [],
  searchString: string
}
