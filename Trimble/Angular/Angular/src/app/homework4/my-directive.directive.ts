import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[background]'
})
export class MyDirectiveDirective {

  constructor(private element: ElementRef) {
    this.element.nativeElement.style.background = 'fuchsia'
  }

}
