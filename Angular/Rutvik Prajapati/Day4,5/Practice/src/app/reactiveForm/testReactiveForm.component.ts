import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit} from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-reactiveformcomp',
  templateUrl: './testReactiveForm.component.html',
  styleUrls: ['./testReactiveForm.component.css']
})
export class TestReactiveFormComponent implements OnInit {

    genders = ['male','female'];
    signupForm!:FormGroup;
    forbiddenUsername=['Rutvik','Anna']

    ngOnInit(){
        this.signupForm = new FormGroup({
            'userData': new FormGroup({
                'username':new FormControl(null,[Validators.required,this.forbiddenNames.bind(this)]),
                'email':new FormControl(null,[Validators.required,Validators.email]),
            }),
            'gender':new FormControl(this.genders[0]),
            'hobbies': new FormArray([])
        });

        // this.signupForm.setValue({
        //     "userData":{
        //         "username":"Max",
        //         "email":"test@gmail.com"
        //     },
        //     "gender":"male",
        //     "hobbies":"cricket"
        // });

        this.signupForm.patchValue({
            "userData":{
                "username":"something"
            }
        })
    }


    OnSubmit()
    {
        console.log(this.signupForm);
    }

    AddHobby()
    {
        var control = new FormControl(null,Validators.required);
        (<FormArray>this.signupForm.get('hobbies')).push(control)
    }

    getHobbies() {
        return (this.signupForm.get('hobbies') as FormArray).controls;
    }
    
    forbiddenNames(control:FormControl):{[s:string]:boolean}
    {
        if(this.forbiddenUsername.indexOf(control.value) !== -1){
            return {"nameIsForbidden":true};
        }
        return null;
    }
}
