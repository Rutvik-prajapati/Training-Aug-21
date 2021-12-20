import { Component } from '@angular/core';

@Component({
  selector: 'app-circle',
  templateUrl: './circle.component.html',
  styleUrls: ['./circle.component.css']
})

export class Circle
{
    radius:number=0;
    pi:number = 3.14;

    areaOfCircle()
    {
        return this.pi*this.radius*this.radius;
    }
}