import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'day1-day2-assignment';
  loadRectangleComponent = false;
  loadLoginComponent = true;
  loadCircleComponent = false;
  loadSignupComponent = false;


  loadMyRectangleComponent()
  {
    if(this.loadRectangleComponent == false)
      this.loadRectangleComponent = true;
    else
      this.loadRectangleComponent = false;
  }
  loadMyLoginComponent()
  {
    if(this.loadLoginComponent == false)
      this.loadLoginComponent = true;
    else
      this.loadLoginComponent = false;
  }

  loadMyCircleComponent()
  {
    if(this.loadCircleComponent == false)
      this.loadCircleComponent = true;
    else
      this.loadCircleComponent = false;
  }

  loadMySignupComponent()
  {
    if(this.loadSignupComponent == false)
      this.loadSignupComponent = true;
    else
      this.loadSignupComponent = false;
  }
}

