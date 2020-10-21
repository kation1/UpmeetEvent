import { Component, Input, OnInit } from '@angular/core';
import { DataAccessEventService } from '../services/data-access-event.service';
import { Event, Events } from './../interfaces/event';

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

  constructor(private eventService: DataAccessEventService) { }

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
}
