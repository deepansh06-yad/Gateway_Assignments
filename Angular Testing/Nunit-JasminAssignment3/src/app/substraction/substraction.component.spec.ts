import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SubstractionComponent } from './substraction.component';

describe('SubstractionComponent', () => {
  let component: SubstractionComponent;
  let fixture: ComponentFixture<SubstractionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SubstractionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SubstractionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('should return substraction of two positive number',()=>{
    const fixture=TestBed.createComponent(SubstractionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=23;
    let b=20;
    expect(fixture.componentInstance.Substract(a,b)).toEqual(3);
  });
  
  it('should not return substraction of two positive number',()=>{
    const fixture=TestBed.createComponent(SubstractionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=23;
    let b=20;
    expect(fixture.componentInstance.Substract(a,b)).not.toEqual(-3);
  });


  
});
