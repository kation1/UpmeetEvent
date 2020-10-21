import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Favorite } from '../interfaces/event';
   

@Injectable({ providedIn: 'root' })
export class DataAccessFavoriteService {
  constructor(private http: HttpClient) {

  }
  apiUrl = '/api/favorite'



  getFavoriteList() {
    return this.http.get(this.apiUrl)
  }

  getFavorite(id) {
    return this.http.get(`${this.apiUrl}/${id}`)
  }

  removeFavorite(id: number) {
    return this.http.delete(`${this.apiUrl}/delete/${id}`)
  }

  addFavorite(newFavorite: Favorite) {
    return this.http.post<Favorite>(this.apiUrl + '/addfavorite', newFavorite)
  }
}
