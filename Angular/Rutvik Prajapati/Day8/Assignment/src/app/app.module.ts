import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { Student } from './Student/student.component';
import { StudentList } from './StudentList/studentList.component';

@NgModule({
  declarations: [
    AppComponent,
    Student,
    StudentList
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
