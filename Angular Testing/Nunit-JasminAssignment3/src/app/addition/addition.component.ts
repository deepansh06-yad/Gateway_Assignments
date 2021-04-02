import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-addition',
  templateUrl: './addition.component.html',
  styleUrls: ['./addition.component.css']
})
export class AdditionComponent{
  positiveAdd(num1:number, num2:number){
    if(num1>0 && num2>0){
     return num1+num2;}
     return "Add positive numbers only";
  }

  negativeAdd(num1: number , num2:number){
    if(num1<0 && num2<0){
      return num1+num2;}
      return "Input negative numbers only";
    }

  MixAdd(num1:number , num2: number){
    if(num1<0 && num2>0){
      return num1+num2;}
      return "Num1 should be less then 0 and Num2 should be greater then 0";
    }
}

 




