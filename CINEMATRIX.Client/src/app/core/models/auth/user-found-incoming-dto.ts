import { ProfileFoundIncomingDto } from "../profile/profile-found-incoming-dto";

export interface UserFoundIncomingDto {
  id: number;
  userName: string;
  email: string;
  roleId: number;
  imageUrl: string;
  profile: ProfileFoundIncomingDto;
}
