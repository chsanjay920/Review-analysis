import { Component, OnInit } from '@angular/core';
import { IMaster } from 'src/app/Interfaces/imaster';

@Component({
  selector: 'app-addideas',
  templateUrl: './addideas.component.html',
  styleUrls: ['./addideas.component.css'],
})
export class AddideasComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}
  Sections: any = {
    movies: true,
    food: false,
    technology: false,
    startupideas: false,
    universities: false,
    politics: false,
    generalproblems: false,
  };
  DivChange(name: string) {
    for (let key in this.Sections) {
      this.Sections[key] = false;
    }
    this.Sections[name] = true;
    console.log(this.Sections);
  }
}
