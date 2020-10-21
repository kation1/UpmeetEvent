import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataAccessEventService } from '../services/data-access-event.service';
import { Event, Events } from './../interfaces/event';

@Component({
    selector: 'app-event-details',
    templateUrl: './event-details.component.html',
    styleUrls: ['./event-details.component.css']
})
/** eventDetails component*/
export class EventDetailsComponent {
  @Input() events: Events;
  frank: Event;

  constructor(private eventService: DataAccessEventService, private route: ActivatedRoute ) { }



  ngOnInit(): void {
    this.route.queryParams.subscribe(
      (data : Event) =>
        this.frank = data)

    this.eventService.getEvent(this.frank).subscribe(
      (data: Event) =>
        this.frank = data)
  };
}
