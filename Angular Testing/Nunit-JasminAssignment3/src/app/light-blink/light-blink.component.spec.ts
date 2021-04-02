import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LightBlinkComponent } from './light-blink.component';

describe('LightBlinkComponent', () => {
  let component: LightBlinkComponent;
  let fixture: ComponentFixture<LightBlinkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LightBlinkComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LightBlinkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('#clicked() should toggle #isOn', () => {
    const comp = new LightBlinkComponent();
    expect(comp.isOn).toBe(false, 'off at first');
    comp.clicked();
    expect(comp.isOn).toBe(true, 'on after click');
    comp.clicked();
    expect(comp.isOn).toBe(false, 'off after second click');
  });

  it('#clicked() should set #message to "is on"', () => {
    const comp = new LightBlinkComponent();
    expect(comp.message).toMatch(/is off/i, 'off at first');
    comp.clicked();
    expect(comp.message).toMatch(/is on/i, 'on after clicked');
  });
});
