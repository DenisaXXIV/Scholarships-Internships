import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/internal/operators/map';
import { Note } from '../interfaces/note.model';

@Injectable({
  providedIn: 'root'
})
export class NoteService {

  readonly baseUrl = 'http://localhost:7169'
  readonly httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Response-Type': 'application/json',
      'Data-Type': 'text'
    }),
  }

  constructor(private http: HttpClient) { }

  serviceCall() {
    console.log("Note service was called");
  }

  getNotes(): Observable<Note[]> {
    return this.http.get<Note[]>(this.baseUrl + "/Notes", this.httpOptions);
  }

  getNote(noteId: string): Observable<Note> {
    return this.http.get<Note>(this.baseUrl + "/Notes/note/"+noteId, this.httpOptions);
  }

  addNote(inputTitle: string, inputDescription: string, inputCategory: string) {
    let note: Note = {
      id : undefined,
      title: inputTitle,
      description: inputDescription,
      categoryId: inputCategory
    }

    let jsonNote=JSON.stringify(note)

    return this.http.post(this.baseUrl + "/Notes/CreateNote", jsonNote, this.httpOptions);
  }

  deleteNote(note: Note) {
    let jsonNoteID=JSON.stringify(note.id)
    // return this.http.delete(this.baseUrl + '/Notes/Delete/' + jsonNoteID, this.httpOptions);
    return this.http.delete(`${this.baseUrl}/Notes/Delete/${note.id}`, this.httpOptions);
  }

  editNote(id: string, inputTitle: string, inputDescription: string, inputCategory: string) {
    let note: Note = {
      title: inputTitle,
      description: inputDescription,
      categoryId: inputCategory
    }
    return this.http.put(this.baseUrl + "/Notes/update" + id, note, this.httpOptions);
  }

  getFilteredNotes(categoryId: string) {
    return this.http.get<Note[]>(this.baseUrl + "/Notes", this.httpOptions)
      .pipe(map((notes: Note[]) => { return notes.filter(note => note.categoryId === categoryId); }));
  }
}
