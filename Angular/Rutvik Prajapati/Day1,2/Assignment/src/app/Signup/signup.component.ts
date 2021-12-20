import { Component } from '@angular/core';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})

export class Signup
{
    signupComponent = false;
    name:string='';
    address:string='';
    panNumber:number=0;

    displayUserDetail()
    {
        if(this.signupComponent == false)
            this.signupComponent = true;
    }
}