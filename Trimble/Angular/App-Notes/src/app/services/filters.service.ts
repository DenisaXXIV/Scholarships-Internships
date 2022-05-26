import { Injectable } from '@angular/core';
import { Category } from '../interfaces/category.model';

@Injectable({
  providedIn: 'root'
})
export class FiltersService {

  private categories: Category[] = [
    { name: 'To Do', id: '1' },
    { name: 'Done', id: '2' },
    { name: 'Doing', id: '3' }
  ];

  constructor() { }

  public getCategories(): Category[] {
    return this.categories;
  }
}
