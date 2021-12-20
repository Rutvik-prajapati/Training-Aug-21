import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import {helloWorld} from './helloWorld/helloWorld.component';
import {Calc} from './calc/calc.component';

@NgModule({
  declarations: [
    AppComponent,
    helloWorld,
    Calc
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
