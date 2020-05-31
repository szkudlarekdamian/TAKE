import { Component, OnInit } from '@angular/core';
import {formatDate} from '@angular/common';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {
  myDate: string;
  
  constructor(){
    this.myDate = formatDate(new Date(), 'full', 'en');

  }

  ngOnInit(): void {
  }

}
