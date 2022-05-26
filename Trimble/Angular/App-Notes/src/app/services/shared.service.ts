import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/internal/BehaviorSubject';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  color: string = '';

  constructor() { }

  private categorySubject: BehaviorSubject<string> = new BehaviorSubject<string>('');
  categoryId$ = this.categorySubject.asObservable();

  public setCategoryId(id: string) {
    this.categorySubject.next(id);
  }


  public setNoteColor(color: string) {
    this.color = color;
  }

  public getColor() {
    return this.color;
  }
}
