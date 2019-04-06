import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-work-experience',
  templateUrl: './work-experience.component.html',
  styleUrls: ['./work-experience.component.css']
})
export class WorkExperienceComponent implements OnInit {

  workExperience = [
    { 
      company: 'MAX', 
      job: 'Sr. Instructor', 
      duration: '2017-',
      description: [
        'Worked as a boot camp instructor teaching three-tier, .Net application development'
      ]
    },
    { 
      company: 'TIY', 
      job: 'Sr. Instructor', 
      duration: '2016-2017',
      description: [
        'Worked as a boot camp instructor teaching three-tier, .Net & Java application development'
      ]
    },
    { 
      company: 'MP', 
      job: 'Sr. Development Manager', 
      duration: '2013-2015',
      description: [
        'Responsible on internal HR systems'
      ]
    }
  ]

  constructor() { }

  ngOnInit() {
  }

}
