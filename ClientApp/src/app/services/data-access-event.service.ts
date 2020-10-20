import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class DataAccessEventService {
    constructor(private http: HttpClient) {
  }

  apiUrl = '/api/Events';

  getEventList() {
    return this.http.get(this.apiUrl)
  }
}
