import { EventEmitter } from '@angular/core';
import { Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { Category } from '../interfaces/category.model';
import { FiltersService } from '../services/filters.service';
import { SharedService } from '../services/shared.service';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.scss']
})
export class FilterComponent implements OnInit {

  categories!: Category[];
  @Output() emitSelectedFilter = new EventEmitter<string>()


  constructor(private filtersService: FiltersService, private sharedService: SharedService) { }

  ngOnInit(): void {
    this.categories = this.filtersService.getCategories();
  }

  selectCategory(categoryId: string) {
    this.emitSelectedFilter.emit(categoryId)
  }


}
