import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/Services/shared.service';

import { FormControl, FormGroup } from '@angular/forms';
import { Client, IReviewsData, ReviewsData } from 'src/app/APIs';

@Component({
  selector: 'app-reviews',
  templateUrl: './reviews.component.html',
  styleUrls: ['./reviews.component.css'],
})
export class ReviewsComponent implements OnInit {
  public SelectedData: any = [];
  public ListOfReviews: any = [];
  public ShowForm: boolean = false;
  public ShowReviews: boolean = false;
  public showanalysis: boolean = false;
  public queryId: any = '';
  constructor(
    private sharedService: SharedService,
    private formdataservice: Client
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
  reviewsForm = new FormGroup({
    review: new FormControl(''),
  });
  ngOnInit(): void {
    this.SelectedData = this.sharedService.getData();
    this.GetReviews();
    if (this.SelectedData.queryId != '') {
      this.ShowReviews = true;
      this.queryId = this.SelectedData.queryid;
    } else {
      this.ShowReviews = false;
    }
  }
  toggleForm() {
    this.ShowForm = !this.ShowForm;
  }
  SubmitReview() {
    const formdata = this.reviewsForm.value;
    console.log('queryid:', this.SelectedData.queryId);
    const review: IReviewsData = {
      review: formdata.review || '',
      queryID: this.SelectedData.queryId,
    };
    this.formdataservice
      .addReview(new ReviewsData(review))
      .subscribe((Response) => {
        console.log(Response);
      });
    this.reviewsForm.reset();
  }

  GetReviews() {
    console.log(this.queryId);
    this.formdataservice
      .getReviews(this.SelectedData.queryId)
      .subscribe((List) => {
        this.ListOfReviews = List;
        console.log(List);
      });
  }
  ShowAnalysis(){
    this.showanalysis =!this.showanalysis;
  }
}
