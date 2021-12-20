import { Component,Output,EventEmitter, OnInit } from '@angular/core';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class Student implements OnInit {
  
    @Output() parentFunction:EventEmitter<any> = new EventEmitter();

    ngOnInit(): void {
        
    }

    studentData = {
        name:"Rutvik Prajapati",
        Age:20,
        std:"12th"
    }

    sendData()
    {
        this.parentFunction.emit(this.studentData);
    }
}
