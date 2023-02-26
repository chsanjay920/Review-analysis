import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './Components/navbar/navbar.component';
import { IdeasfeedComponent } from './Components/ideasfeed/ideasfeed.component';
import { AddideasComponent } from './Components/addideas/addideas.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { RegisterComponent } from './Components/register/register.component';
import { ProfileComponent } from './Components/profile/profile.component';
const routes: Routes = [
  {path:'',component:IdeasfeedComponent},
  {path:'ideas',component:IdeasfeedComponent},
  {path:'addideas',component:AddideasComponent},
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'profile',component:ProfileComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    IdeasfeedComponent,
    AddideasComponent,
    LoginComponent,
    RegisterComponent,
    ProfileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
  ],
  exports: [RouterModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
