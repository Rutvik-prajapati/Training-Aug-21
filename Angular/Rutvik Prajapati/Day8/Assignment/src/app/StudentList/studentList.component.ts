import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-studentList',
  templateUrl: './studentList.component.html',
  styleUrls: ['./studentList.component.css']
})
export class StudentList {
  @Input() studentListData:any;
}
