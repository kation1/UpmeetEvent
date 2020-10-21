import { Component } from '@angular/core';
import { Favorites } from '../interfaces/event';
import { DataAccessFavoriteService } from '../services/data-access-favorite.service';


@Component({
    selector: 'app-favorite',
    templateUrl: './favorite.component.html',
    styleUrls: ['./favorite.component.css']
})
/** favorite component*/
export class FavoriteComponent {

  favorites: Favorites;
  
  /** favorite ctor */
  constructor(private favoriteService: DataAccessFavoriteService) { }
  ngOnInit(): void {

    this.favoriteService.getFavoriteList().subscribe(
      (data: Favorites) =>
        this.favorites = data)

  };
 
}
