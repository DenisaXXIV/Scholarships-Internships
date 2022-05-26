import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Note } from '../interfaces/note.model';
import { FiltersService } from '../services/filters.service';
import { NoteService } from '../services/note.service';
import { PinService } from '../services/pin.service';
import { SharedService } from '../services/shared.service';

@Component({
  selector: 'app-edit-note',
  templateUrl: './edit-note.component.html',
  styleUrls: ['./edit-note.component.scss']
})
export class EditNoteComponent implements OnInit {

  noteTitle: string ='';
  noteDescription: string='';
  deadline: string='';
  urgent: boolean= false;
  pinColor: string='';


  constructor(private noteService: NoteService, 
    private filterService: FiltersService, 
    private router: Router, 
    private sharedService: SharedService,
    private pinService: PinService) { }

  ngOnInit(): void {
  }

  editNote() {
    let noteToEdit: Note = {
      id: Math.random().toString(36).substring(7),
      title: this.noteTitle,
      description: this.noteDescription,
      deadLine: new Date(1 / 1 / 1999),
      isUrgent: false,
      pin: this.pinService.setPinToNote('3'),
      background: ''
    }

    this.noteService.addNote(noteToEdit);
    this.router.navigate(['notes']);
    // this.sharedService.setNoteColor(noteToAdd.color);
  }

}
