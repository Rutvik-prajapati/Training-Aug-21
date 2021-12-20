import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'day8-practice';

  //data = "Rutvik Prajapati";
          //OR

  data = {
    name:"Rutvik Prajapati",
    age:20,
  }

  //parent to child
  name="";
  parentFunction(data:any)
  {
    this.name = data.name;
    console.log(data);
  }
}
