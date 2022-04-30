import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FollowReasonComponent } from './follow-reason.component';

describe('FollowReasonComponent', () => {
  let component: FollowReasonComponent;
  let fixture: ComponentFixture<FollowReasonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FollowReasonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FollowReasonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
