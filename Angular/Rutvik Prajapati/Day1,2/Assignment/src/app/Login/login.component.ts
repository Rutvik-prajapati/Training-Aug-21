import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class Login
{
    username:string='';
    password:string=''

    validateUser()
    {
        if(this.username == 'admin' && this.password == 'admin')
            return 'successfully login';
        else
            return 'enter proper credential';
    }
}