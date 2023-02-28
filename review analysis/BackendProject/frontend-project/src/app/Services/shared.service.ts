import { EventEmitter, Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  constructor() { }
  data: any;
  eventEmitter = new EventEmitter<any>();

  setData(data: any) {
    this.data = data;
    this.eventEmitter.emit(data);
  }

  getData() {
    return this.data;
  }
}
