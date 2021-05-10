import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'wp-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  colors = [
    'blue',
    'red',
    'purple',
    'pink',
    'green',
    'orange'
  ];
  categories = [
    'Trending',
    'Sports',
    'Politics',
    'Regional'
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
