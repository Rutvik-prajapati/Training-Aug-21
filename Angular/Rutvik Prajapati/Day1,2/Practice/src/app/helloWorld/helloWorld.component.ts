import {Component} from '@angular/core';

@Component({
    // selector:'[app-helloWorld]',  just like css attribute
    // selector:'.app-helloWorld',
    selector:'app-helloWorld',
    templateUrl:'./helloWorld.component.html',
    styleUrls: ['./helloWorld.component.css']
})

export class helloWorld
{
    allowNewHelloWorld = false;
    name:string="Rutvik Prajapati";

    constructor(){
        setTimeout(() => {
            this.allowNewHelloWorld = true;
        }, 2000);
    }
}