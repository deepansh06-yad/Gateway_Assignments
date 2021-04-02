import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MultiplicationComponent } from './multiplication.component';

describe('MultiplicationComponent', () => {
  let component: MultiplicationComponent;
  let fixture: ComponentFixture<MultiplicationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MultiplicationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MultiplicationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should return multiplication of two positive number',()=>{
    const fixture=TestBed.createComponent(MultiplicationComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=3;
    let b=2;
    expect(fixture.componentInstance.Multiply(a,b)).toEqual(6);
  });

  it('should not return multiplication of two positive number',()=>{
    const fixture=TestBed.createComponent(MultiplicationComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=3;
    let b=2;
    expect(fixture.componentInstance.Multiply(a,b)).not.toEqual(8);
  });
});
