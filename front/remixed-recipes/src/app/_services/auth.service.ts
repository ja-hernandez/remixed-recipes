import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const AUTH_API = 'https://localhost:5001/accounts/';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private http: HttpClient) { }

  login(email: string, password: string): Observable<any> {
    return this.http.post(AUTH_API + 'authenticate', {
      email,
      password
    }, httpOptions);
  }

  register(title: string, firstName: string, lastName: string, email: string, password: string, confirmPassword: string, acceptTerms: boolean): Observable<any> {
    return this.http.post(AUTH_API + 'register', {
      title,
      firstName,
      lastName,
      email,
      password,
      confirmPassword,
      acceptTerms
    }, httpOptions);
  }
}
