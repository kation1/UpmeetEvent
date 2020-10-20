import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
   

@Injectable()
export class DataAccessFavoriteService {
  constructor(private http: HttpClient) {

  }
  apiUrl = '/api/Favorite'



  getFavoriteList() {
    return this.http.get(this.apiUrl)
  }

  getFavorite(id) {
    return this.http.get(`${this.apiUrl}/${id}`)
  }

  removeFavorite(id) {
    return this.http.get(`${this.apiUrl}/delete/${id}`)
  }
}
