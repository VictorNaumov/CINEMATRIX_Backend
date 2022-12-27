import { FAQFoundIncomingDto } from "./faq";

export interface FAQSearchIncomingDto {
  items: FAQFoundIncomingDto[],
  totalCount: number
}
