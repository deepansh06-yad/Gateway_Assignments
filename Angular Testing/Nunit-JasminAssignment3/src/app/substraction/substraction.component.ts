import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-substraction',
  templateUrl: './substraction.component.html',
  styleUrls: ['./substraction.component.css']
})
export class SubstractionComponent implements OnInit {

  Substract(num1:number, num2:number){
    if(num1>num2 && num2>0){
     return num1-num2;}
     return "Substract positive numbers only";
  }
  constructor() { }

  ngOnInit(): void {
  }

}
