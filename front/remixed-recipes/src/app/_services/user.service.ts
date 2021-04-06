import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

const API_URL = 'https://localhost:5001/';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private http: HttpClient) { }

  getPublicContent(): Observable<any> {
    return this.http.get(API_URL + 'api/recipe', { responseType: 'text' });
  }
  getAllUsers(): Observable<any> {
    return this.http.get(API_URL + 'accounts/users', { responseType: 'text' });
  }

  getUserBoard(): Observable<any> {
    return this.http.get(API_URL + 'accounts/users' + 'id', { responseType: 'text' });
  }
}