import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataAccessEventService } from '../services/data-access-event.service';
import { DataAccessFavoriteService } from '../services/data-access-favorite.service';
import { Event, Events, Favorite } from './../interfaces/event';

@Component({
    selector: 'app-event-details',
    templateUrl: './event-details.component.html',
    styleUrls: ['./event-details.component.css']
})
/** eventDetails component*/
export class EventDetailsComponent {
  @Input() events: Events;
  frank: Event;
  favorite: Favorite;

  constructor(private eventService: DataAccessEventService, private route: ActivatedRoute, private favoriteService: DataAccessFavoriteService) { }



  ngOnInit(): void {
    this.route.queryParams.subscribe(
      (data : Event) =>
        this.frank = data)

    this.eventService.getEvent(this.frank).subscribe(
      (data: Event) =>
        this.frank = data)
  };

  addFavorite() {
    let newFavorite: any = {
      id: 0,
      userID: "TestUser",
      EventID: this.frank.id
    }
    console.log(this.frank.id, 'frankid');
    console.log(newFavorite);
    this.favoriteService.addFavorite(newFavorite).subscribe();
  }
}
