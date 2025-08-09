import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { UserGetDto } from "./interfaces/user-get.dto";
import { UserRoleDto } from "./interfaces/user-role.dto";

@Injectable({ providedIn: 'root' })
export class UserApiService {
    private readonly apiUrl = 'https://localhost:7088/api/admin';

    constructor(private http: HttpClient) { }

    public getAllUsers(): Observable<UserGetDto[]> {
        const url = `${this.apiUrl}/get-users`;
        return this.http.get<UserGetDto[]>(url);
    }

    public deleteUser(userId: number): Observable<void> {
        const url = `${this.apiUrl}/${userId}`;
        return this.http.delete<void>(url);
    }

    public setRole(userId: number, role: UserRoleDto): Observable<void> {
        debugger;
        const url = `${this.apiUrl}/update-role?userId=${userId}&userRoleDto=${role}`;
        return this.http.put<void>(url, null);
    }
}
