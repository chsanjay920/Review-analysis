import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import WeatherForecast from './weather-forecast';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'frontend-project';
  public forecasts: WeatherForecast[] = [];
  constructor(http: HttpClient) {
    http.get<WeatherForecast[]>('https://localhost:7186/api/' + 'weatherforecast').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}
