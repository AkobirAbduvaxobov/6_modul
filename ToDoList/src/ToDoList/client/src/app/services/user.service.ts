import { inject, Injectable, PLATFORM_ID } from '@angular/core';
import { Observable, map, tap } from 'rxjs';
import { ItemApiService } from '../api/item-api-service';
import { ItemCreateModel } from './models/item-create-model';
import { ItemCreateDto } from '../api/interfaces/item-create-dto';
import { ItemGetDto } from '../api/interfaces/item-get-dto';
import { ItemGetModel } from './models/item-get-model';
import { ItemUpdateModel } from './models/item-update-model';
import { ItemUpdateDto } from '../api/interfaces/item-update-dto';
import { UserApiService } from '../api/user-api-service';
import { UserGetDto } from '../api/interfaces/user-get.dto';
import { UserGetModel } from './models/user-get.model';
import { UserRoleDto } from '../api/interfaces/user-role.dto';
import { UserRoleModel } from './models/user-role.model';

@Injectable({ providedIn: 'root' })
export class UserService {
    router: any;
    constructor(private userApiService: UserApiService) { }

    public getAllUsers(): Observable<UserGetModel[]> {
        return this.userApiService.getAllUsers().pipe(
            map((dtoList: UserGetDto[]) => dtoList.map(dto => this.convertItemGetDtoToModel(dto)))
        );
    }

    private convertItemGetDtoToModel(dto: UserGetDto): UserGetModel {
        return {
            userId: dto.userId,
            firstName: dto.firstName,
            lastName: dto.lastName,
            userName: dto.userName,
            email: dto.email,
            phoneNumber: dto.phoneNumber,
            role: this.convertUserRoleDtoToModel(dto.role)
        };
    }

    private convertUserRoleDtoToModel(roleDto: UserRoleDto): UserRoleModel {
        switch (roleDto) {
            case UserRoleDto.Admin:
                return UserRoleModel.Admin;
            case UserRoleDto.SuperAdmin:
                return UserRoleModel.SuperAdmin;
            default:
                return UserRoleModel.User;
        }
    }
}
