import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import {Rectangle} from './Rectangle/rectangle.component';
import {Login} from './Login/login.component';
import {Circle} from './Circle/circle.component';
import {LeftBar} from './LeftBar/leftbar.component';
import {Signup} from './Signup/signup.component';

@NgModule({
  declarations: [
    AppComponent,
    Rectangle,
    Login,
    Circle,
    LeftBar,
    Signup
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
