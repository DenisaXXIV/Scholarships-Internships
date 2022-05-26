import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'myPipe'
})
export class MyPipePipe implements PipeTransform {

  transform(value: string): string {
    if (typeof value === 'string') return "\"" + value + "\" " + "is a string"
    else return "\"" + value + "\" " + " is NOT a string"
    return ''
  }

}
