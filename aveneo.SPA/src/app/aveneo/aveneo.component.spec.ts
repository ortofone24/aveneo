/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { AveneoComponent } from './aveneo.component';

describe('AveneoComponent', () => {
  let component: AveneoComponent;
  let fixture: ComponentFixture<AveneoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AveneoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AveneoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
