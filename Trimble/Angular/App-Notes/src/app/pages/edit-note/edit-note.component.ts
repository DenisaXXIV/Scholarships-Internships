import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Category } from 'src/app/interfaces/category.model';
import { Note } from 'src/app/interfaces/note.model';
import { NoteService } from 'src/app/services/note.service';

@Component({
  selector: 'app-edit-note',
  templateUrl: './edit-note.component.html',
  styleUrls: ['./edit-note.component.scss']
})
export class EditNoteComponent implements OnInit {
  categories : Category[] = [];
  note!: Note;
  id: string = ''

  constructor(private noteService: NoteService,
    private router: Router,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params =>this.id = params["id"])
      this.noteService.getNote(this.id).subscribe(note=> this.note=note);
  }

  editNote() {
    
    this.noteService.editNote(this.id,this.note.title,this.note.description,this.note.categoryId);
    this.router.navigate(['notes']);
  }

}
