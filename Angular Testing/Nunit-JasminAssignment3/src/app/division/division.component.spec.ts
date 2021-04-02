import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DivisionComponent } from './division.component';

describe('DivisionComponent', () => {
  let component: DivisionComponent;
  let fixture: ComponentFixture<DivisionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DivisionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DivisionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should return division of two number',()=>{
    const fixture=TestBed.createComponent(DivisionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=8;
    let b=2;
    expect(fixture.componentInstance.Divide(a,b)).toEqual(4);
  });

  it('should not return division of two number',()=>{
    const fixture=TestBed.createComponent(DivisionComponent);
    fixture.detectChanges();
    const save=fixture.nativeElement;
    let a=8;
    let b=2;
    expect(fixture.componentInstance.Divide(a,b)).not.toEqual(8);
  });
});
