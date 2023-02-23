import { PageDTOBase } from "../page-abstractions/paged-dto-base";

export interface FAQSearchOutgoingDto extends PageDTOBase {
  question: string[];
  answer: string[];
  category: string[];
}
