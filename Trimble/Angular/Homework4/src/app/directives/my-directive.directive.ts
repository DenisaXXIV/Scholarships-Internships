import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[background]'
})
export class MyDirectiveDirective {

  constructor(private elRef: ElementRef) {
    this.elRef.nativeElement.style.background = 'fuchsia'
  }

}
