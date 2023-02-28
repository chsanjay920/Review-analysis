import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Client } from 'src/app/APIs';
import { SharedService } from 'src/app/Services/shared.service';

@Component({
  selector: 'app-ideasfeed',
  templateUrl: './ideasfeed.component.html',
  styleUrls: ['./ideasfeed.component.css'],
})
export class IdeasfeedComponent implements OnInit {
  constructor(
    private formdataservice: Client,
    private sharedService: SharedService,
    private router:Router
  ) {}
  public TypeModel: any = {
    food: 'Food',
    generalproblem: 'GeneralProblems',
    movies: 'Movies',
    politics: 'Politics',
    startups: 'StartUps',
    technology: 'Technology',
    universities: 'Universities',
  };
  public FeedData: any = [];
  ngOnInit() {
    this.LoadFeedData();
    
  }
  LoadFeedData() {
    this.formdataservice.getFeedData().subscribe((Response) => {
      this.FeedData = Response;
    });
  }
  selectData(data:any) {
    this.sharedService.setData(data);
    this.router.navigate(['/reviews'])
  }
}
