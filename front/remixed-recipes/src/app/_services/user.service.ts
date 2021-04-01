import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Account } from '../_models';
import { environment } from "./../../environments/environment";


@Injectable({ providedIn: 'root' })
export class UserService {
    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<Account[]>(`${environment.apiUrl}/accounts`);
    }
}