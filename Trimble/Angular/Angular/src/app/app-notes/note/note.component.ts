import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Note } from '../interfaces/note.model';
import { NoteService } from '../services/note.service';
import { PinService } from '../services/pin.service';
import { Router } from '@angular/router';
import { Input } from '@angular/core';
import { Subscription } from 'rxjs/internal/Subscription';
import * as pinsData from '../../../assets/pins.json';
import { PinList } from '../interfaces/pin-list.model';

@Component({
  selector: 'app-note',
  templateUrl: './note.component.html',
  styleUrls: ['./note.component.scss']
})
export class NoteComponent implements OnInit, OnChanges {

  notes: Note[] = [];
  // iconPaths: string[] = [];
  categoryType: string = '';
  pinColor: string = '';
  colors: string[] = ['#ffada5', '#f091d0', '#61cf61', '#63e4a8', '#FFE6E6',
    '#eff89a', '#ffa87f', '#ffb273', '#66fbfb', '#B8E3EB', '#ac9dfb', '#DFA1A1'
    , '#FDBFBF', '#EDF47A', '#80E7E5', '#D1D1F6', '#D8BFD8', '#E9FAE3', '#E1FFE9'];
  category: string[] = [];
  @Input()
  selectedCategoryId!: string;
  filteredNotesSub: Subscription = new Subscription;
  getNotesSub: Subscription = new Subscription;
  pins: PinList[] = [];

  constructor(private noteService: NoteService,
    private pinService: PinService,
    private router: Router) { }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.selectedCategoryId) {
      this.filteredNotesSub = this.noteService
        .getFilteredNotes(this.selectedCategoryId)
        .subscribe((notes) => {
          this.notes = notes
        })
      this.selectedCategoryId = ''
    }

  }

  ngOnInit(): void {
    this.getNotesSub = this.noteService.getNotes().subscribe((notes) => {
      this.notes = notes
    });

    this.setPins();

    this.changeAspect();
  }

  deleteNote(note: Note) {
    this.noteService.deleteNote(note);
  }

  setPins() {
    this.pins = (pinsData as any).default;

    for (var index = 0; index < this.notes.length; index++) {
      this.pinService.setPin(this.notes[index], this.pins[index].id);
    }
  }

  editNote(note: Note) {
    this.router.navigateByUrl(`/edit-note/${note.id}`)
  }

  private changeAspect() {
    for (let index = 0; index < this.notes.length; index++) {

      var index2 = Math.floor(Math.random() * this.colors.length);
      this.notes[index].background = this.colors[index2];

      this.category[index] = this.pinService.getCategoryName(this.notes[index].pin.id);
    }
  }

  doingNote(note: Note) {
    for (let index = 0; index < this.notes.length; index++) {
      if (this.notes[index].id == note.id) {
        switch (this.notes[index].pin.id) {
          case '1':
            this.pinService.changePin('4', note);
            break;
          case '2':
            this.pinService.changePin('5', note);
            break;
          case '3':
            this.pinService.changePin('6', note);
            break;
          default:
            this.pinService.changePin('6', note);
            break;

        }
      }
    }
  }

  doneNote(note: Note) {
    for (let index = 0; index < this.notes.length; index++) {
      if (this.notes[index].id == note.id) {
        switch (this.notes[index].pin.id) {
          case '1':
            this.pinService.changePin('7', note);
            break;
          case '2':
            this.pinService.changePin('8', note);
            break;
          case '3':
            this.pinService.changePin('9', note);
            break;
          case '4':
            this.pinService.changePin('7', note);
            break;
          case '5':
            this.pinService.changePin('8', note);
            break;
          case '6':
            this.pinService.changePin('9', note);
            break;
          default:
            this.pinService.changePin('9', note);
            break;

        }
      }
    }
  }
}
