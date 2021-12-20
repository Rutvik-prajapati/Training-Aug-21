import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit} from '@angular/core';
import { FormArray, FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';


@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class Student implements OnInit {
    
    studentAdmissionForm:FormGroup;
    studentList:IStudent[] = [];
    studentInfo:IStudent;
    
    ngOnInit()
    {
        this.studentAdmissionForm = new FormGroup({
            "studentData":new FormGroup({
                "firstName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "middleName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "lastName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "dateOfBirth":new FormControl('',Validators.required),
                "placeOfBirth":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "firstLanguage":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "address":new FormGroup({
                    "city":new FormControl('',[Validators.required,Validators.pattern('[a-zA-Z]*')]),
                    "state":new FormControl('',[Validators.required,Validators.pattern('[a-zA-Z]*')]),
                    "country":new FormControl('',[Validators.required,Validators.pattern('[a-zA-Z]*')]),
                    "pin":new FormControl('',[Validators.required,Validators.pattern('[0-9]{6,6}')])
                })
            }),
            "studentFatherData":new FormGroup({
                "firstName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "middleName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "lastName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "email":new FormControl('',[Validators.required,Validators.email]),
                "educationQualification":new FormControl('',Validators.required),
                "profession":new FormControl('',Validators.required),
                "designation":new FormControl('',Validators.required),
                "phone":new FormControl('',Validators.required)
            }),
            "studentMotherData":new FormGroup({
                "firstName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "middleName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "lastName":new FormControl('',[Validators.required,Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]),
                "email":new FormControl('',[Validators.required,Validators.email]),
                "educationQualification":new FormControl('',Validators.required),
                "profession":new FormControl('',Validators.required),
                "designation":new FormControl('',Validators.required),
                "phone":new FormControl('',Validators.required)
            })
            // "emergencyContactList":new FormGroup({
            //     "relation":new FormArray([]),
            //     "contact":new FormArray([])
            // }),
            // "referenceDetails":new FormGroup({

            // })
        })
    }

    OnSubmit()
    {
        this.studentInfo = {
            studentAdmission:{
                studentData : {
                    firstName:this.studentAdmissionForm.value.studentData.firstName,
                    middleName:this.studentAdmissionForm.value.studentData.middleName,
                    lastName:this.studentAdmissionForm.value.studentData.lastName,
                    dateOfBirth:this.studentAdmissionForm.value.studentData.dateOfBirth,
                    placeOfBirth:this.studentAdmissionForm.value.studentData.placeOfBirth,
                    firstLanguage:this.studentAdmissionForm.value.studentData.firstLanguage,
                    address:{
                        city:this.studentAdmissionForm.value.studentData.address.city,
                        state:this.studentAdmissionForm.value.studentData.address.state,
                        country:this.studentAdmissionForm.value.studentData.address.country,
                        pin:this.studentAdmissionForm.value.studentData.address.pin
                    }
                },
                studentFatherData : {
                    firstName : this.studentAdmissionForm.value.studentFatherData.firstName,
                    middleName : this.studentAdmissionForm.value.studentFatherData.middleName,
                    lastName : this.studentAdmissionForm.value.studentFatherData.lastName,
                    email : this.studentAdmissionForm.value.studentFatherData.email,
                    educationQualification : this.studentAdmissionForm.value.studentFatherData.educationQualification,
                    profession : this.studentAdmissionForm.value.studentFatherData.profession,
                    designation : this.studentAdmissionForm.value.studentFatherData.designation,
                    phone : this.studentAdmissionForm.value.studentFatherData.phone
                },
                studentMotherData : {
                    firstName : this.studentAdmissionForm.value.studentFatherData.firstName,
                    middleName : this.studentAdmissionForm.value.studentFatherData.middleName,
                    lastName : this.studentAdmissionForm.value.studentFatherData.lastName,
                    email : this.studentAdmissionForm.value.studentFatherData.email,
                    educationQualification : this.studentAdmissionForm.value.studentFatherData.educationQualification,
                    profession : this.studentAdmissionForm.value.studentFatherData.profession,
                    designation : this.studentAdmissionForm.value.studentFatherData.designation,
                    phone : this.studentAdmissionForm.value.studentFatherData.phone
                }
            }
        }
        
        this.studentList.push(this.studentInfo);
        console.log(this.studentAdmissionForm);
        console.log(this.studentList);
        this.studentAdmissionForm.reset();
    }
}

interface IStudent{
    studentAdmission:{
        studentData : {
            firstName:string
            middleName:string
            lastName:string
            dateOfBirth:Date
            placeOfBirth:string
            firstLanguage:string
            address:{
                city:string
                state:string
                country:string
                pin:number
            }
        }
        studentFatherData : {
            firstName:string
            middleName:string
            lastName:string
            email:string
            educationQualification:string
            profession:string
            designation:string
            phone:string
        }
        studentMotherData : {
            firstName:string
            middleName:string
            lastName:string
            email:string
            educationQualification:string
            profession:string
            designation:string
            phone:string
        }
    }
}