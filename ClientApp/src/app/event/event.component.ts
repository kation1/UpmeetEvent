import { Component, Input, OnInit } from '@angular/core';
import { DataAccessEventService } from '../services/data-access-event.service';
import { DataAccessFavoriteService } from '../services/data-access-favorite.service';
import { Event, Events, Favorite, UserFavorite } from './../interfaces/event';

@Component({
    selector: 'app-event',
    templateUrl: './event.component.html',
    styleUrls: ['./event.component.css']
})
/** event component*/
export class EventComponent {
  @Input() events: Events;
  event: Event;
  name: string;
  date: string;
  id: number;

  constructor(private eventService: DataAccessEventService, private favoriteService: DataAccessFavoriteService) { }

  ngOnInit(): void{
    this.eventService.getEventList().subscribe(
      (data: Events) =>
        this.events = data)
  };

  doHidden = function () {
    this.isHidden = !this.isHidden;
  }

  addEvent() {
    let newEvent: Event = {
      id: 0,
      name: this.name,
      date: this.date,
    }
    console.log(this.name);
    console.log(newEvent);
    this.eventService.addEvent(newEvent).subscribe();

  }

  addFavorite() {
    let newFavorite: Favorite = {
      id: 0,
      userID: "TestUser",
      EventID: this.id
    }
    console.log(this.event.id);
    console.log(newFavorite);
    this.favoriteService.addFavorite(newFavorite).subscribe();
  }
}
