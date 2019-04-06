import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css']
})
export class EducationComponent implements OnInit {

  schoolClass: string = "red";
  education = [
    { 
      school: 'Athenaeum of Ohio',
      degree: 'MA Cert LPM',
      year: '2013'
    },
    { 
      school: 'University of Cincinnati',
      degree: 'BS IPS',
      year: '1885'
    },
    {
      school: 'St. X',
      degree: 'College Prep',
      year: '1975'
    }
  ]

  constructor() { }

  ngOnInit() {
  }

}
