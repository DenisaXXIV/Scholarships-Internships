import { Component, EventEmitter, OnInit } from '@angular/core';
import { Output } from '@angular/core';
import { Category } from 'src/app/interfaces/category.model';
import { FiltersService } from 'src/app/services/filters.service';
import { SharedService } from 'src/app/services/shared.service';

@Component({
  selector: 'app-filters',
  templateUrl: './filters.component.html',
  styleUrls: ['./filters.component.scss']
})
export class FiltersComponent implements OnInit {

  categories!: Category[];
  @Output() emitSelectedFilter = new EventEmitter<string>()
  
  constructor(private filtersService: FiltersService) { }

  ngOnInit(): void {
    this.categories = this.filtersService.getCategories();
  }

  selectCategory(categoryId: string) {
    this.emitSelectedFilter.emit(categoryId)
  }
}
