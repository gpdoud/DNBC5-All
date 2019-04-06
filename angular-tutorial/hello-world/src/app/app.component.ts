import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular 7';
  subtitle: string = "From .Net BC 5";

  inputTxt: string = "default input text";

  changeTitle(txt: string): void {
    this.title = txt;
  }
}
