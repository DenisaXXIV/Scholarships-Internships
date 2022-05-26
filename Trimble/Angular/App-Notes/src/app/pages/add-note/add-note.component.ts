import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Category } from 'src/app/interfaces/category.model';
import { Note } from 'src/app/interfaces/note.model';
import { FiltersService } from 'src/app/services/filters.service';
import { NoteService } from 'src/app/services/note.service';

@Component({
  selector: 'app-add-note',
  templateUrl: './add-note.component.html',
  styleUrls: ['./add-note.component.scss']
})
export class AddNoteComponent implements OnInit {

  noteTitle: string = '';
  noteDescription: string = '';
  categories: Category[] = [];
  selectedCategoryId: string = ''

  constructor(private noteService: NoteService,
    private router: Router, private activatedRoute: ActivatedRoute,
    private filtersService: FiltersService) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(note =>
      (
        console.log(note['id'])
      ))

    this.categories = this.filtersService.getCategories();
  }

  addNote() {
    this.noteService.addNote(this.noteTitle,this.noteDescription,this.selectedCategoryId).subscribe();
    //this.router.navigate(['notes']);
  }

}
