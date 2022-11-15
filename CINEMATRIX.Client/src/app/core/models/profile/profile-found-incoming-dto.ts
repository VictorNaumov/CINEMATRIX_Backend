import { TicketFoundIncomingDto } from "../ticket/ticket-found-incoming-dto"

export interface ProfileFoundIncomingDto {
  id: number,
  name: string,
  secondName: string,
  dateOfBirth: Date,
  phoneNumber: Date,
  imageUrl: string,
  tickets: TicketFoundIncomingDto[];
}
