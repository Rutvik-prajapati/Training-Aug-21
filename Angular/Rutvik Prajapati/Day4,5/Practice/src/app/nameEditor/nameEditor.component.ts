import { Component} from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-name-editor',
  templateUrl: './nameEditor.component.html',
  styleUrls: ['./nameEditor.component.css']
})
export class NameEditorComponent  {
  name = new FormControl('');

  updateName(){
    this.name.setValue('Nancy');
  }
}
