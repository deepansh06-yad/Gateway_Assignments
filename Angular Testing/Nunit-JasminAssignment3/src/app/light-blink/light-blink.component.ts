import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-light-blink',
  templateUrl: './light-blink.component.html',
  styleUrls: ['./light-blink.component.css']
})
export class LightBlinkComponent implements OnInit {

  isOn = false;
  clicked() { this.isOn = !this.isOn; }
  get message() { return `The light is ${this.isOn ? 'On' : 'Off'}`; }
  constructor() { }

  ngOnInit(): void {
  }

}
