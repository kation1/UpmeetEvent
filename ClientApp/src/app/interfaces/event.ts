export interface Events {
  results: Event[];
}

export interface Event {
  id: number;
  name: string;
  date: string;
}

export interface Favorite {
  id: number;
  userID: string;
  EventID: number;
}

export interface Favorites {
  results: Favorite[];
}

export interface UserFavorite {
  name: string;
  date: string;
  userId: string;
  id: number;
}

export interface UserFavorites {
  results: UserFavorite[];
}
