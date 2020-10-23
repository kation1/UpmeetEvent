import { Component } from '@angular/core';
import { Favorites, UserFavorite, UserFavorites } from '../interfaces/event';
import { DataAccessFavoriteService } from '../services/data-access-favorite.service';


@Component({
    selector: 'app-favorite',
    templateUrl: './favorite.component.html',
    styleUrls: ['./favorite.component.css']
})
/** favorite component*/
export class FavoriteComponent {

  userFavorites: UserFavorites;
  userFavorite: UserFavorite;

  /** favorite ctor */
  constructor(private favoriteService: DataAccessFavoriteService) { }
  ngOnInit(): void {

    this.favoriteService.getFavoriteList().subscribe(
      (data: UserFavorites) =>
        this.userFavorites = data)

  };

  removeFavorite(fav: UserFavorite) {

    console.log(fav.id);
    this.favoriteService.removeFavorite(fav.id).subscribe();

  }



}
