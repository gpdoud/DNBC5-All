import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  name: string = 'Greg Doud';
  address: string = '4900 Parkway Dr.'
  cityStateZip: string = 'Mason, OH 45040'
  email: string = 'gdoud@maxtrain.com';
  phone: string = '513-322-8888';

  
}
