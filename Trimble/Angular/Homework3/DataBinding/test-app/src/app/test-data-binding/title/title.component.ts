import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'appTitle',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.scss']
})
export class TitleComponent implements OnInit {

  background: string= ""
  color: string=""

  ngOnInit():void {}

  setBackground() {
    const c=new Option().style;
    c.color=this.color;
    if(c.color==this.color.toLowerCase())
      this.background=this.color;
      else
      this.color="";
  }

}
