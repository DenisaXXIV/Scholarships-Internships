import { Injectable } from '@angular/core';
import { Note } from '../interfaces/note.model';
import { PinService } from './pin.service';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NoteService {

  readonly baseUrl = 'http://localhost:4200'
  readonly httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    }),
  }

  // private notes: Note[] = [
  //   {
  //     id: "Id1",
  //     title: "First note",
  //     description: "This is the description for the first note",
  //     deadLine: new Date(25 / 5 / 2022),
  //     isUrgent: false,
  //     pin: "1",
  //     background: ''
  //   },
  //   {
  //     id: "Id2",
  //     title: "Second note",
  //     description: "This is the description for the second note",
  //     deadLine: new Date(14 / 7 / 2022),
  //     isUrgent: false,
  //     pin: "5",
  //     background: ''
  //   },
  //   {
  //     id: "Id3",
  //     title: "Third note",
  //     description: "This is the description for the second note",
  //     deadLine: new Date(4 / 6 / 2022),
  //     isUrgent: false,
  //     pin: "9",
  //     background: ''
  //   }
  // ];

  constructor(private http: HttpClient, private pinService: PinService) { }

  serviceCall() {
    console.log("Note service was called");
  }

  getNotes(): Observable<Note[]> {
    return this.http.get<Note[]>(this.baseUrl + `/notes`, this.httpOptions);
  }

  getNote(noteId: string) {
    return this.http.get<Note>(this.baseUrl + `/notes/${noteId}`);
  }

  addNote(note: Note) {
    return this.http
      .post(this.baseUrl + '/notes', note, this.httpOptions).subscribe();
  }

  deleteNote(note: Note) {
    return this.http
      .delete(this.baseUrl + `/notes/${note.id}`, this.httpOptions).subscribe();
  }

  editNote(id: string, note: Note) {
    console.log(note)
    return this.http.put(this.baseUrl + `/notes/${id}`, note).subscribe();
  }

  getFilteredNotes(categoryId: string) {
    return this.http
      .get<Note[]>(this.baseUrl + `/notes`, this.httpOptions)
      .pipe(
        map((notes) => notes.filter((note) => note.pin.category == categoryId)),
      )
  }

}
