import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: [`
    .online{
      color:red;
    }
  `]
})
export class AppComponent {
  title = 'day3-practice';
  username = '';

  GetColor()
  {
    if(this.username == '')
      return 'blue';
    else
      return 'Yellow';
  }
}
