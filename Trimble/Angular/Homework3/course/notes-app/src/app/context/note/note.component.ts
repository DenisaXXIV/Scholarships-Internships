import { Component, OnChanges, OnInit } from '@angular/core';
import { Note } from 'src/app/utility/interfaces/note.model';
import { NoteService } from 'src/app/utility/services/note.service';

@Component({
  selector: 'app-note',
  templateUrl: './note.component.html',
  styleUrls: ['./note.component.scss']
})
export class NoteComponent implements OnInit, OnChanges {

  notes!: Note[];

  constructor(private noteService: NoteService) { }

  ngOnInit() {
    this.noteService.serviceCall();
    this.notes = this.noteService.getNotes();
  }

  ngOnChanges(): void {
  }

}
