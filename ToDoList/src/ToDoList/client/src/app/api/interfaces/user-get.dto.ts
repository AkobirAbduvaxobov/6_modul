import { UserRoleDto } from "./user-role.dto";

export interface UserGetDto {
  userId: number;
  firstName: string;
  lastName: string;
  userName: string;
  email: string;
  phoneNumber: string;
  role: UserRoleDto;
}
