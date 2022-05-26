import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  templateUrl: './data-binding.component.html',
  styleUrls: ['./data-binding.component.scss']
})
export class DataBindingComponent implements OnInit {

  background: string = ""
  color: string = ""

  constructor() { }

  ngOnInit(): void {
  }

  setBackground() {
    const c = new Option().style;
    c.color = this.color;
    if (c.color == this.color.toLowerCase())
      this.background = this.color;
    else
      this.color = "";
  }

}
