import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-division',
  templateUrl: './division.component.html',
  styleUrls: ['./division.component.css']
})
export class DivisionComponent implements OnInit {
  Divide(num1:number, num2:number){
    if(num1>num2 && num2>0 || num1>num2 && num2<0){
     return num1/num2;}
     return "Divide numbers only";
  }
  constructor() { }

  ngOnInit(): void {
  }

}
