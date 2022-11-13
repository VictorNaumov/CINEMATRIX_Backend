import { SeatFoundIncomingDto } from "../seat/seat-found-incoming-dto"

export interface HallDto {
  name: string,
  description: string,
  soundSystem: string,
  projector: string,
  screen: string,
  screenResolution: string
  seats: SeatFoundIncomingDto[]
}
