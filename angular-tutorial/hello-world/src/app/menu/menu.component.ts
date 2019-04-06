import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  name = 'Greg';

  constructor() { }

  toggle() {
    this.name = (this.name === 'Greg') ? 'Doud' : 'Greg';
  }

  ngOnInit() {
  }

}
