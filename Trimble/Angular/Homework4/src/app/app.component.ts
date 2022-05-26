import { formatDate } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent{
  firstString: string = 'first'
  secondString: string = 'second'
  elementList: Date[] = [
    new Date("Aug 5 2002"),
    new Date("Ap 20 2014"),
    new Date("Jan 24 2001"),
    new Date("Mar 7 1976"),
    new Date("Aug 4 1973"),
  ]
  title: any;
}
