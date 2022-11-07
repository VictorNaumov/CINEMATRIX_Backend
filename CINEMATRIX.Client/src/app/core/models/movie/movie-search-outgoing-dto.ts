export interface MovieSearchOutgoingDto {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  title: string [],
  searchString: string
}
