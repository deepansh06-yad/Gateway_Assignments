import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdditionComponent } from './addition.component';

describe('AdditionComponent', () => {
  let component: AdditionComponent;
  let fixture: ComponentFixture<AdditionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdditionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdditionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should return addition of two positive number',()=>{
    const fixture=TestBed.createComponent(AdditionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=21;
    let b=22;
    expect(fixture.componentInstance.positiveAdd(a,b)).toEqual(43);
  })

  it('should not return addition of two positive number',()=>{
    const fixture=TestBed.createComponent(AdditionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=21;
    let b=22;
    expect(fixture.componentInstance.positiveAdd(a,b)).not.toEqual(23);
  })
  it('should return addition of two negative number',()=>{
    const fixture=TestBed.createComponent(AdditionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=-21;
    let b=-22;
    expect(fixture.componentInstance.negativeAdd(a,b)).toEqual(-43);
  })

  it('should not return addition of two negative number',()=>{
    const fixture=TestBed.createComponent(AdditionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=-21;
    let b=-22;
    expect(fixture.componentInstance.negativeAdd(a,b)).not.toEqual(23);
  })
  it('should return addition of second number positive and first number negative number',()=>{
    const fixture=TestBed.createComponent(AdditionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=-21;
    let b=22;
    expect(fixture.componentInstance.MixAdd(a,b)).toEqual(1);
  })

  it('should not return addition of second number positive and first number negative number',()=>{
    const fixture=TestBed.createComponent(AdditionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=-21;
    let b=22;
    expect(fixture.componentInstance.MixAdd(a,b)).not.toEqual(23);
  })
});
