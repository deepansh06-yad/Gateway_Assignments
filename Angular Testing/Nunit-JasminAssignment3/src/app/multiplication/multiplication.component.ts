import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-multiplication',
  templateUrl: './multiplication.component.html',
  styleUrls: ['./multiplication.component.css']
})
export class MultiplicationComponent implements OnInit {

  Multiply(num1:number, num2:number){
    if(num1>0 && num2>0){
     return num1*num2;}
     return "Multiply numbers only";
  }
  constructor() { }

  ngOnInit(): void {
  }

}
