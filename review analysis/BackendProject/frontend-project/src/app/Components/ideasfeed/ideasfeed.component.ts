import { Component, OnInit } from '@angular/core';
import { Client } from 'src/app/APIs';

@Component({
  selector: 'app-ideasfeed',
  templateUrl: './ideasfeed.component.html',
  styleUrls: ['./ideasfeed.component.css'],
})
export class IdeasfeedComponent implements OnInit {
  constructor(private formdataservice: Client) {}
  public TypeModel:any = {
    food:"Food",
    generalproblem:"GeneralProblems",
    movies:'Movies',
    politics:"Politics",
    startups:"StartUps",
    technology:"Technology",
    universities:"Universities"
  }
  public FeedData: any = [];
  ngOnInit(){
    this.LoadFeedData();
  }
   LoadFeedData() {
    this.formdataservice.getFeedData().subscribe((Response) => {
      this.FeedData = Response;
      console.log(Response);
    });
  }
}
