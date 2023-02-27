import { Component, OnInit } from '@angular/core';
import { IMaster } from 'src/app/Interfaces/imaster';
import { FormControl, FormGroup } from '@angular/forms';
import { Client, Food, GeneralProblems, IFood, IGeneralProblems, IMovies, IPolitics, IStartupIdeas, ITechnology, IUniversities, Movies, Politics, StartupIdeas, Technology, Universities } from 'src/app/APIs';

@Component({
  selector: 'app-addideas',
  templateUrl: './addideas.component.html',
  styleUrls: ['./addideas.component.css'],
})
export class AddideasComponent implements OnInit {

  constructor(private formdataservice: Client) {}

  ngOnInit(): void {}

  moviesForm = new FormGroup({
    moviename:new FormControl(''),
    moviestory:new FormControl(''),
    moviecast:new FormControl(''),
    budget:new FormControl('')
  });
  FoodForm = new FormGroup({
    restaurant:new FormControl(''),
    description:new FormControl(''),
    veg:new FormControl(''),
    nonveg:new FormControl(''),
    both:new FormControl(''),
    location:new FormControl('')
  });
  GeneralProblemsForm = new FormGroup({
    Subject:new FormControl(''),
    Description:new FormControl(''),
    Locaiton:new FormControl(''),
  });
  PoliticsForm = new FormGroup({
    politicianName:new FormControl(''),
    party:new FormControl(''),
    age:new FormControl(''),
    qualification:new FormControl(''),
    description:new FormControl('')
  });
  StartUpForms = new FormGroup({
    title:new FormControl(''),
    description:new FormControl(''),
    investment:new FormControl(''),
    location:new FormControl('')
  });
  TechnologyForm = new FormGroup({
    gadgetName:new FormControl(''),
    desciption:new FormControl(''),
    launchdate:new FormControl(''),
    price:new FormControl('')
  })
  UniversitiesForm = new FormGroup({
    universityName:new FormControl(''),
    courseOffered:new FormControl(''),
    description:new FormControl(''),
    fee:new FormControl(''),
    EstablishedYear:new FormControl(''),
    Location:new FormControl('')
  });
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
  AddMovies(){
    const formdata = this.moviesForm.value;
    const movies:IMovies={
      moviename:formdata.moviename||'',
      movieStory:formdata.moviestory||'',
      cast:formdata.moviecast||'',
      budget:Number(formdata.budget)||0,
    }
    this.formdataservice.addMoviesIdeas(new Movies(movies)).subscribe(Response=>{
      console.log(Response);
    });
  }
  AddFood()
  {
    const formdata = this.FoodForm.value;
    const food:IFood={
      restaurant:formdata.restaurant||'',
      foodtype:formdata.veg||formdata.nonveg||formdata.both||'',
      description:formdata.description||'',
      location:formdata.location||'',
    }
    this.formdataservice.addFoodIdeas(new Food(food)).subscribe(Response =>{
      console.log(Response);
    })
    this.FoodForm.reset();
  }
  AddGeneralProblems(){
    const formdata = this.GeneralProblemsForm.value;
    const generalproblems:IGeneralProblems={
      subject:formdata.Subject||'',
      description:formdata.Description||'',
      location:formdata.Locaiton||'',
    }
    this.formdataservice.addGeneralProblems(new GeneralProblems(generalproblems)).subscribe(Response=>{
      console.log(Response);
    })
    this.GeneralProblemsForm.reset();
  }
  AddPolitics(){
    const formdata = this.PoliticsForm.value;
    const politics:IPolitics={
      politicianName:formdata.politicianName||'',
      party:formdata.party||'',
      age:Number(formdata.age)||0,
      qualification:formdata.qualification||'',
      description:formdata.description||''
    }
    this.formdataservice.addPoliticsIdeas(new Politics(politics)).subscribe(Response=>{
      console.log(Response);
    })
    this.PoliticsForm.reset();
  }
  AddStartUps(){
    const formdata = this.StartUpForms.value;
    const startupideas:IStartupIdeas = {
      title:formdata.title||'',
      description:formdata.description||'',
      investmentAmount:Number(formdata.investment)||0,
      location:formdata.location||'',
    }
    this.formdataservice.addStartupIdeas(new StartupIdeas(startupideas)).subscribe(Response=>{
      console.log(Response);
    });
    this.StartUpForms.reset();
  }
  AddTechnology(){
    const formdata = this.TechnologyForm.value;
    const technology:ITechnology = {
      gadgetname:formdata.gadgetName||'',
      description:formdata.desciption||'',
      prize:Number(formdata.price)||0,
      launchdate:new Date("2022-03-01T00:00:00")||(formdata.launchdate?new Date(formdata.launchdate):new Date("2022-03-01T00:00:00")),
    }
    this.formdataservice.addTechnologyIdeas(new Technology(technology)).subscribe(Response=>{
      console.log(Response);
    });
    this.TechnologyForm.reset();
  }
  Adduniversity(){
    const formdata = this.UniversitiesForm.value;
    const universities:IUniversities={
      universityname:formdata.universityName||'',
      courseOffered:formdata.courseOffered||'',
      description:formdata.description||'',
      fee:Number(formdata.fee)||0,
      establishedYear:(formdata.EstablishedYear?new Date(formdata.EstablishedYear):new Date("2022-03-01T00:00:00")),
      location:formdata.Location||'',
    }
    this.formdataservice.addUniversitiesIdeas(new Universities(universities)).subscribe(Response=>{
      console.log(Response);
    })
    this.UniversitiesForm.reset();
  }
}
