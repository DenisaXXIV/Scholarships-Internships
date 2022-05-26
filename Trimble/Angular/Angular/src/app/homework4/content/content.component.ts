import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss']
})
export class ContentComponent implements OnInit {
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

  constructor() { }

  ngOnInit(): void {
  }

}
