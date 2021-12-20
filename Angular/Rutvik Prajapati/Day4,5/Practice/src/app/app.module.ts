import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { FormsModule,ReactiveFormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { NameEditorComponent } from './nameEditor/nameEditor.component';
import { TestReactiveFormComponent } from './reactiveForm/testReactiveForm.component';
import { TempDrivenComponent } from './tempDrivenForm/tempDrivenForm.component';

@NgModule({
  declarations: [
    AppComponent,
    NameEditorComponent,
    TestReactiveFormComponent,
    TempDrivenComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
