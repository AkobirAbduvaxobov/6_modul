import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { UserGetDto } from "./interfaces/user-get.dto";

@Injectable({ providedIn: 'root' })
export class UserApiService {
    private readonly apiUrl = 'https://localhost:7088/api/admin';

    constructor(private http: HttpClient) { }

    public getAllUsers(): Observable<UserGetDto[]> {
        const url = `${this.apiUrl}/get-users`;
        return this.http.get<UserGetDto[]>(url);
    }
}
