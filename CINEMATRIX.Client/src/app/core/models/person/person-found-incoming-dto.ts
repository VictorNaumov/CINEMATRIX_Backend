import { ImageDto } from "../extends/image-dto"
import { PersonCreditsDto } from "../extends/person-credits-dto"

export interface PersonFoundIncomingDto {
  id: number,
  name: string,
  gender: number,
  birthDay: Date,
  deathDay: Date,
  biography: string,
  popularity: number,
  adult: boolean,
  placeOfBirth: string,
  images: ImageDto[],
  credits: PersonCreditsDto[]
}
