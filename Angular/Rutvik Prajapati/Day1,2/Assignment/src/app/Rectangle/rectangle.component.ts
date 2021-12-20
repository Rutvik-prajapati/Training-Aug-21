import { Component } from '@angular/core';

@Component({
  selector: 'app-rectangle',
  templateUrl: './rectangle.component.html',
  styleUrls: ['./rectangle.component.css']
})

export class Rectangle
{
    Length:number = 0;
    Width:number = 0;

    areaOfRectangle()
    {
        return this.Length*this.Width;
    }
}