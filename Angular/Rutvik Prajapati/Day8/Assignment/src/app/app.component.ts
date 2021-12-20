import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  stuInfo={
    name:"",
    age:0,
    std:""
  }
  parentFunction(data:any)
  {
    this.stuInfo.name = data.name;
    this.stuInfo.age = data.Age;
    this.stuInfo.std = data.std;
  }

  studentList:any[] = [{name:"Rahul",age:15,std:"10th"},
                       {name:"Anjali",age:16,std:"11th"},
                       {name:"Chintu",age:14,std:"9th"},
                       {name:"Rohan",age:12,std:"7th"},
                       {name:"Parth",age:10,std:"5th"}]
}
