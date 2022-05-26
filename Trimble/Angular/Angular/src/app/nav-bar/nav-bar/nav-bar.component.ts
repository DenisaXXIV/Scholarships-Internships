import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'navBar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  openMenu() {
    document.getElementById("mySidenav")!.style.width = "100%";
    document.body.style.backgroundColor = "rgba(26, 0, 0,0.8)";
  }

  closeMenu() {
    document.getElementById("mySidenav")!.style.width = "0";
    document.body.style.backgroundColor = "white";
  }

}
