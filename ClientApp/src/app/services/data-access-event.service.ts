import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Event } from '../interfaces/event';

@Injectable({ providedIn: 'root' })
export class DataAccessEventService {
    constructor(private http: HttpClient) {
  }

  apiUrl = '/api/Event';

  getEventList() {
    return this.http.get(this.apiUrl)
  }

  getEvent(id) {
    return this.http.get(`${this.apiUrl}/${id}`)
  }

  addEvent(newEvent: Event) {
    return this.http.post<Event>(this.apiUrl + '/create', newEvent)
  }

}
