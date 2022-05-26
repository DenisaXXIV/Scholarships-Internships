import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/utility/interfaces/category.model';
import { Note } from 'src/app/utility/interfaces/note.model';
import { FiltersService } from 'src/app/utility/services/filters.service';
import { NoteService } from 'src/app/utility/services/note.service';

@Component({
  selector: 'app-add-note',
  templateUrl: './add-note.component.html',
  styleUrls: ['./add-note.component.scss']
})
export class AddNoteComponent implements OnInit {

  noteTitle!: string;
  noteDescription!: string;
  categories!: Category[];
  selectedCategoryId!: string;
  noteDeadLine!: Date;

  constructor(private noteService: NoteService, private filterService: FiltersService, private router: Router,) {
  }

  ngOnInit() {
    this.categories = this.filterService.getCategories();
  }

  addNote(){
    let noteToAdd: Note = {
      id: Math.random().toString(36).substring(7),
      title: this.noteTitle,
      description: this.noteDescription,
      deadLine: this.noteDeadLine
    }

    this.noteService.addNote(noteToAdd);
    this.router.navigate(['']);
  }

}
