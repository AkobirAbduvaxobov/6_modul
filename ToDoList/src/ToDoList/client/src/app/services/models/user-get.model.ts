import { UserRoleModel } from "./user-role.model";

export class UserGetModel {
  userId: number = 0;
  firstName: string = ''
  lastName: string = ''
  userName: string = ''
  email: string = ''
  phoneNumber: string = ''
  role: UserRoleModel = UserRoleModel.User;
}