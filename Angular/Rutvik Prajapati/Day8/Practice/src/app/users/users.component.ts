import { Component,Input,Output,EventEmitter, OnInit } from '@angular/core';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class Users implements OnInit{
    @Input() user:any;

    @Output() parentFunction:EventEmitter<any> = new EventEmitter();

    ngOnInit(): void {
        // var userInfo={name:"rutvik P",age:20};
        // this.parentFunction.emit(userInfo);
    }

    sendData()
    {
        var userInfo={name:"rutvik P",age:20};
        this.parentFunction.emit(userInfo);
    }
}
