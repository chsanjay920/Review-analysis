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
  searchTerm: string = '';
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
  filterItems() {
    if(this.searchTerm && this.searchTerm.trim())
    {
      this.FeedData = this.FeedDataSortable;
      this.FeedData =  this.FeedData.filter((item: any) => {
        console.log(item);
        if (item.queryCategory == 'Movies')
        {
          console.log(item);
          return (
            item.moviename
              .includes(this.searchTerm.toLowerCase()) ||
            item.movieCast
              .includes(this.searchTerm.toLowerCase()) ||
            item.movieStory.toLowerCase().includes(this.searchTerm.toLowerCase())
          );
        }
        else if (item.queryCategory == 'Food')
        {
          return (
            item.restaurant
              .includes(this.searchTerm.toLowerCase()) ||
            item.foodDescription
              .includes(this.searchTerm.toLowerCase())
          );
        }
        else if (item.queryCategory == 'Technology')
        {
          return (
            item.technologyDescription
              .includes(this.searchTerm.toLowerCase()) ||
            item.technologyName
              .includes(this.searchTerm.toLowerCase())
          );
        }
        else if (item.queryCategory == 'StartUps')
        {
          return (
            item.startUpdescription
              .includes(this.searchTerm.toLowerCase()) ||
            item.startUpTitle
              .includes(this.searchTerm.toLowerCase())
          );
        }
        else if (item.queryCategory == 'Universities')
        {
          return (
            item.universityname
              .includes(this.searchTerm.toLowerCase()) ||
            item.universityDescription
              .includes(this.searchTerm.toLowerCase())
          );
        }
        else if (item.queryCategory == 'Politics')
        {
          return (
            item.politicianName
              .includes(this.searchTerm.toLowerCase()) ||
            item.politicalDescription
              .includes(this.searchTerm.toLowerCase()) ||
            item.politicalParty
              .includes(this.searchTerm.toLowerCase())
          );
        }
        else if (item.queryCategory == 'GeneralProblems')
        {
          return (
            item.generalProblemDescription
              .includes(this.searchTerm.toLowerCase()) ||
            item.generalProblemSubject
              .includes(this.searchTerm.toLowerCase())
          );
        }
      });
    }
    else{
      this.FeedData = this.FeedDataSortable;
    }
  }
  onSortByChange(e: any) {
    if (e.value == 'newest') {
      this.FeedData.sort(
        (a: any, b: any) =>
          b.queryUploadedAt.getTime() - a.queryUploadedAt.getTime()
      );
    } else if (e.value == 'category') {
      this.FeedData.sort((a: any, b: any) =>
        a.queryCategory > b.queryCategory
          ? 1
          : b.queryCategory > a.queryCategory
          ? -1
          : 0
      );
    } else if (e.value == 'food') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === 'Food'
      );
    } else if (e.value == 'movies') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === 'Movies'
      );
    } else if (e.value == 'technology') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === 'Technology'
      );
    } else if (e.value == 'StartUp') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === 'StartUps'
      );
    } else if (e.value == 'Universities') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === 'Universities'
      );
    } else if (e.value == 'Political') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === 'Politics'
      );
    } else if (e.value == 'generalproblem') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData = this.FeedData.filter(
        (item: any) => item.queryCategory === 'GeneralProblems'
      );
    } else if (e.value == 'recommended') {
      this.FeedData = this.FeedDataSortable;
      this.FeedData.sort((a: any, b: any) =>
        a.queryId > b.queryId ? 1 : b.queryId > a.queryId ? -1 : 0
      );
    }
  }
}
