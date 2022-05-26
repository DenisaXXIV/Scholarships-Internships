import { Component, Input, OnInit, SimpleChanges } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs/internal/Subscription';
import { Note } from 'src/app/interfaces/note.model';
import { NoteService } from 'src/app/services/note.service';

@Component({
  selector: 'app-note',
  templateUrl: './note.component.html',
  styleUrls: ['./note.component.scss']
})
export class NoteComponent implements OnInit {

  notes: Note[] = [];
  categoryType: string = '';
  pinColor: string = '';
  backgrounds: string[] = [];
  colors: string[] = ['#ffada5', '#f091d0', '#61cf61', '#63e4a8', '#FFE6E6',
    '#eff89a', '#ffa87f', '#ffb273', '#66fbfb', '#B8E3EB', '#ac9dfb', '#DFA1A1'
    , '#FDBFBF', '#EDF47A', '#80E7E5', '#D1D1F6', '#D8BFD8', '#E9FAE3', '#E1FFE9'];
  category: string[] = [];
  @Input()
  selectedCategoryId!: string;
  filteredNotesSub: Subscription = new Subscription;
  getNotesSub: Subscription = new Subscription;

  constructor(private noteService: NoteService,
    private router: Router) { }

    ngOnChanges(): void {
      this.noteService.getNotes().subscribe((notes:Note[]) => {this.notes = notes});

      if (this.selectedCategoryId) {
        this.filteredNotesSub = this.noteService
          .getFilteredNotes(this.selectedCategoryId)
          .subscribe((notes:Note[]) => {this.notes = notes})
        this.selectedCategoryId = ''
      }
    }

  ngOnInit(): void {
    this.getNotesSub = this.noteService.getNotes().subscribe((notes) => {
      this.notes = notes
    });

    this.changeAspect();
  }

  deleteNote(note: Note) {
    this.noteService.deleteNote(note).subscribe();

    this.ngOnChanges();
  }

  editNote(note: Note) {
    this.router.navigateByUrl(`/edit-note/${note.id}`);
  }

  private changeAspect() {
    for (let index = 0; index < this.notes.length; index++) {
      var index2 = Math.floor(Math.random() * this.colors.length);
      this.backgrounds[index] = this.colors[index2];
    }
  }
}
