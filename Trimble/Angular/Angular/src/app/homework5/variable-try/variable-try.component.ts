import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-variable-try',
  templateUrl: './variable-try.component.html',
  styleUrls: ['./variable-try.component.scss']
})
export class VariableTryComponent implements OnInit {

  nr!: number

  constructor(private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe((parameters) => {
      this.nr = parameters['nr']
    })
  }

}

