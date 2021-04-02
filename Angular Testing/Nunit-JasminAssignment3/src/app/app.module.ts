import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdditionComponent } from './addition/addition.component';
import { SubstractionComponent } from './substraction/substraction.component';
import { MultiplicationComponent } from './multiplication/multiplication.component';
import { DivisionComponent } from './division/division.component';
import { LightBlinkComponent } from './light-blink/light-blink.component';

@NgModule({
  declarations: [
    AppComponent,
    AdditionComponent,
    SubstractionComponent,
    MultiplicationComponent,
    DivisionComponent,
    LightBlinkComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
