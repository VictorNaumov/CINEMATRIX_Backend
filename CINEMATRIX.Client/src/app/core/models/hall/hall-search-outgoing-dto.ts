import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface HallSearchOutgoingDto extends PageDTOBase {
  name: string[],
  description: string[],
  soundSystem: string[],
  projector: string[],
  screen: string[],
  screenResolution: string[]
}
