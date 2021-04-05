import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { environment } from '@environments/environment';
import { User } from '@app/_models';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    private userSubject = new BehaviorSubject<User>(new User());
    public user = this.userSubject.asObservable(); 

    constructor(
        private router: Router,
        private http: HttpClient
    ) { }

    public get userValue(): User {
        return this.userSubject.value;
    }


    login(email: string, password: string) {
        return this.http.post<any>(`${environment.apiUrl}/accounts/authenticate`, { email, password}, { withCredentials: true })
            .pipe(map(user => {
                this.userSubject.next(user);
                this.startRefreshTokenTimer();
                return user;
            }));
    }

    logout() {
        this.http.post<any>(`${environment.apiUrl}/accounts/revoke-token`, {}, { withCredentials: true }).subscribe();
        this.stopRefreshTokenTimer();
        this.userSubject.next(new User);
        this.router.navigate(['/login']);
    }

    refreshToken() {
        return this.http.post<any>(`${environment.apiUrl}/accounts/refresh-token`, {}, { withCredentials: true })
            .pipe(map((user) => {
                this.userSubject.next(user);
                this.startRefreshTokenTimer();
                return user;
            }));
    }

    // helper methods

    private refreshTokenTimeout: any;

    private startRefreshTokenTimer() {
        // parse json object from base64 encoded jwt token
        if (this.userValue.jwtToken != null) {
            const jwtToken = JSON.parse(atob(this.userValue.jwtToken.split('.')[1]));

            // set a timeout to refresh the token a minute before it expires
            const expires = new Date(jwtToken.exp * 1000);
            const timeout = expires.getTime() - Date.now() - (60 * 1000);
            this.refreshTokenTimeout = setTimeout(() => this.refreshToken().subscribe(), timeout);
        }
    }
        

    private stopRefreshTokenTimer() {
        clearTimeout(this.refreshTokenTimeout);
    }
}