import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  color: string = '';

  constructor() { }

  private categorySubject: BehaviorSubject<string> = new BehaviorSubject<string>('');
  categoryId$ = this.categorySubject.asObservable();

  // public setCategoryID(id: string){
  //   this.categoryId = id;
  // }

  // public getCategoryID(): string {
  //   return this.categoryId;
  // }

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
