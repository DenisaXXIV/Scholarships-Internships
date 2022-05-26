import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tools',
  templateUrl: './tools.component.html',
  styleUrls: ['./tools.component.scss']
})
export class ToolsComponent implements OnInit {

  title = 'Title';
  shownTitle!: string;

  constructor() { }

  ngOnInit(): void {
  }

  setTitle() {
    this.shownTitle = this.title;
  }

}
