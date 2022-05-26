import { Injectable } from '@angular/core';
import { Note } from '../interfaces/note.model';
import { Pin } from '../interfaces/pin.model';
import { FiltersService } from './filters.service';
import { SharedService } from './shared.service';

@Injectable({
  providedIn: 'root'
})
export class PinService {

  private pins: Pin[] = [
    {
      id: '1',
      name: 'toDo_Blue',
      path: '../../assets/pins/toDo(1).png',
      category: '1',
    },
    {
      id: '2',
      name: 'toDo_Green',
      path: '../../assets/pins/toDo(2).png',
      category: '1',
    },
    {
      id: '3',
      name: 'toDo_Red',
      path: '../../assets/pins/toDo(3).png',
      category: '1',
    },

    {
      id: '4',
      name: 'Done_Blue',
      path: '../../assets/pins/done(1).png',
      category: '2',
    },
    {
      id: '5',
      name: 'Done_Green',
      path: '../../assets/pins/done(2).png',
      category: '2',
    },
    {
      id: '6',
      name: 'Done_Red',
      path: '../../assets/pins/done(3).png',
      category: '2',
    },

    {
      id: '7',
      name: 'Doing_Blue',
      path: '../../assets/pins/doing(1).png',
      category: '3',
    },
    {
      id: '8',
      name: 'Doing_Green',
      path: '../../assets/pins/doing(2).png',
      category: '3',
    },
    {
      id: '9',
      name: 'Doing_Red',
      path: '../../assets/pins/doing(3).png',
      category: '3',
    },
  ];

  constructor(sharedService: SharedService, filterService: FiltersService) { }

  public getPins(): Pin[] {
    return this.pins;
  }

  public getPin(id: string): Pin {
    for (var index = 0; index < this.pins.length; index++) {
      if (this.pins[index].id == id) {
        return this.pins[index];
      }
    }
    return this.pins[3];
  }

  public changePin(newId: string, note: Note) {
    for (var index = 0; index < this.pins.length; index++) {
      if (this.pins[index].id == newId) {
        note.pin = this.pins[index];
      }
    }
  }

  public setPin(note: Note, id: string) {
    note.pin = this.getPin(id);
  }

  public setPinToNote(id: string) {
    return this.getPin(id);
  }

  public getPath(id: string): string {
    for (var index = 0; index < this.pins.length; index++) {
      if (this.pins[index].id == id) {
        return this.pins[index].path;
      }
    }
    return '';
  }

  public getCategory(id: string): string {
    for (var index = 0; index < this.pins.length; index++) {
      if (this.pins[index].id == id) {
        return this.pins[index].category;
      }
    }
    return '';
  }

  public getCategoryName(id: string): string {
    for (var index = 0; index < this.pins.length; index++) {
      if (this.pins[index].id == id) {
        switch (this.pins[index].category) {
          case '1':
            return 'TO DO';
          case '2':
            return 'DONE';
          case '3':
            return 'DOING';
          default:
            return 'TO DO';
        }
      }
    }
    return '';
  }
}
