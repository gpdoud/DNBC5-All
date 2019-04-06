import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  list(): Observable<any> {
    return this.http.get("http://localhost:54371/api/users") as Observable<any>;
  }

  constructor(private http: HttpClient) { }
}
