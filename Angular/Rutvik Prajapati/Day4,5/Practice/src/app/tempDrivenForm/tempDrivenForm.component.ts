import { Component, ElementRef, ViewChild} from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-temp-driven',
  templateUrl: './tempDrivenForm.component.html',
  styleUrls: ['./tempDrivenForm.component.css']
})
export class TempDrivenComponent  {
  @ViewChild('f') signupForm?:NgForm;  //this is access form local varible using viewChild
  
  submit='false';
  defaultValue='rutvik';
//   defaultUserName="rutvikP6"
  answer='';
  genders = ['male','female']

  user={
    username:'',
    email:'',
    secret:'',
    questionAnswer:'',
    gender:''
  };

  suggestUserName()
  {
    const superUserName = 'Superuser'
    //   this.signupForm?.setValue({
    //       userData:{
    //           username:superUserName,
    //           email:'test@gmal.com'
    //       },
    //       secret:'pet',
    //       questionanswer:'',
    //       gender:'male'
    //   });

    //or

    this.signupForm?.form.patchValue({
        userData:{
            username:superUserName
        }
    });
  }
    // onSubmit(form:NgForm)
    // {
    //     console.log(form);
    // }

    //or

    onSubmit()
    {
        this.user.username = this.signupForm?.value.userData.username;
        this.user.email = this.signupForm?.value.userData.email;
        this.user.questionAnswer = this.signupForm?.value.questionanswer;
        this.user.secret=this.signupForm?.value.secret;
        this.user.gender = this.signupForm?.value.gender;
    }
}
