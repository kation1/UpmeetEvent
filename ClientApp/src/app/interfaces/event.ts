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
