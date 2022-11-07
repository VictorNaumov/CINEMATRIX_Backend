export interface HallSearchOutgoingDto {
  pageSize: number,
  page: number,
  sortDirection: string,
  sortProperty: string,
  name: string[],
  description: string[],
  soundSystem: string[],
  projector: string[],
  screen: string[],
  screenResolution: string[]
}
