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
    private router: Router
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
  public FeedDataSortable: any = [];
  ngOnInit() {
    this.LoadFeedData();
  }
  LoadFeedData() {
    this.formdataservice.getFeedData().subscribe((Response) => {
      this.FeedData = Response;
      console.log(this.FeedData);
      this.FeedDataSortable = Response;
    });
  }
  selectData(data: any) {
    this.sharedService.setData(data);
    this.router.navigate(['/reviews']);
  }
  onSortByChange(e: any) {
    if (e.value == 'newest') {
      this.FeedData.sort((a: any, b: any) => 
        b.queryUploadedAt.getTime() - a.queryUploadedAt.getTime()
      );
    } else if (e.value == 'category') {
      this.FeedData.sort((a:any,b:any) => (a.queryCategory > b.queryCategory) ? 1 : ((b.queryCategory > a.queryCategory) ? -1 : 0))
    } else if (e.value == 'food') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === "Food"
      );
    } else if (e.value == 'movies') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === "Movies"
      );
    } else if (e.value == 'technology') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === "Technology"
      );
    } else if (e.value == 'StartUp') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === "StartUps"
      );
    } else if (e.value == 'Universities') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === "Universities"
      );
    } else if (e.value == 'Political') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === "Politics"
      );
    } else if (e.value == 'generalproblem') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === "GeneralProblems"
      );
    }
    else if (e.value == 'recommended') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData.sort((a:any,b:any) => (a.queryId > b.queryId) ? 1 : ((b.queryId > a.queryId) ? -1 : 0))
    }
  }
}
