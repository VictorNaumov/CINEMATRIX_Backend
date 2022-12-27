export interface FAQSearchOutgoingDto {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  question: string[];
  answer: string[];
  category: string[];
}
