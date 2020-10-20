import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class DataAccessEventService {
    constructor(private http: HttpClient) {
  }

  apiUrl = '/api/Events';

  getEvents() {
    return this.http.get(this.apiUrl)
  }
}
