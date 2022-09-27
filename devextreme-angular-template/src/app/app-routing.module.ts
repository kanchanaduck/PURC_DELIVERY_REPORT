import { NgModule } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http'; 
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { LoginFormComponent, ResetPasswordFormComponent, CreateAccountFormComponent, ChangePasswordFormComponent } from './shared/components';
import { AuthGuardService } from './shared/services';
import { ReactiveFormsModule } from '@angular/forms';

import { HomeComponent } from './pages/home/home.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { TasksComponent } from './pages/tasks/tasks.component';

import { Reason12Component } from './reason/reason12/reason12.component';
import { Reason3Component } from './reason/reason3/reason3.component';

import { ReportPur12Component } from './pages/report-pur12/report-pur12.component';
import { ReportPur3Component } from './pages/report-pur3/report-pur3.component';

import { Pur12Component } from './input/pur12/pur12.component';

import { Pur3ControlDomesticComponent } from './input/pur3-control-domestic/pur3-control-domestic.component';
import { Pur3ControlOverseaComponent } from './input/pur3-control-oversea/pur3-control-oversea.component';
import { Pur3PoIssueComponent } from './input/pur3-po-issue/pur3-po-issue.component';
import { Pur3PuChampComponent } from './input/pur3-pu-champ/pur3-pu-champ.component';
import { Pur3EvalioComponent } from './input/pur3-evalio/pur3-evalio.component';
import { Pur3ShotLTComponent } from './input/pur3-short-lt/pur3-short-lt.component';
import { Pur3DelayDomesticComponent } from './input/pur3-delay-domestic/pur3-delay-domestic.component';
import { Pur3DelayOverseaComponent } from './input/pur3-delay-oversea/pur3-delay-oversea.component';

import { ProgressPur12Component } from './progress/progress-pur12/progress-pur12.component';

import { 
  DxDataGridModule, 
  DxFormModule,
  DxCheckBoxModule, 
  DxFileUploaderModule, 
  DxRadioGroupModule,
  DxTabPanelModule,
  DxTemplateModule,
  DxToolbarModule,
  DxPopupModule, 
  DxButtonModule,
  DxLoadPanelModule,
  DxBoxModule,
  DxSelectBoxModule, 
  DxTagBoxModule,
  DxTextBoxModule,
  DxTextAreaModule,
  DxResponsiveBoxModule,
  DxDrawerModule,
  DxToastModule,
  DxPivotGridModule,
  DxSchedulerModule,
  DxButtonGroupModule,
  DxDropDownButtonModule
 } from 'devextreme-angular';



const routes: Routes = [
  
  {
    path: 'reason/reason-pur1-2',
    component: Reason12Component,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'reason/reason-pur3',
    component: Reason3Component,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur3-delay-oversea',
    component: Pur3DelayOverseaComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur3-delay-domestic',
    component: Pur3DelayDomesticComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur3-shot-lt',
    component: Pur3ShotLTComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur3-evalio',
    component: Pur3EvalioComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur3-puchamp',
    component: Pur3PuChampComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur3-poissued',
    component: Pur3PoIssueComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur3-control-oversea',
    component: Pur3ControlOverseaComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur3-control-domestic',
    component: Pur3ControlDomesticComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'input/pur1-2',
    component: Pur12Component,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/report-pur3',
    component: ReportPur3Component,
    canActivate: [ AuthGuardService ]
  },
  /*{
    path: 'pages/follow-reason',
    component: FollowReasonComponent,
    canActivate: [ AuthGuardService ]
  },*/
  {
    path: 'progress/pur1-2',
    component: ProgressPur12Component,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/report-pur1-2',
    component: ReportPur12Component,
    canActivate: [ AuthGuardService ]
  },
  /* {
    path: 'pages/create',
    component: CreateComponent,
    canActivate: [ AuthGuardService ]
  }, */
  {
    path: 'tasks',
    component: TasksComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'profile',
    component: ProfileComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'home',
    component: HomeComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'login-form',
    component: LoginFormComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'reset-password',
    component: ResetPasswordFormComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'create-account',
    component: CreateAccountFormComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'change-password',
    component: ChangePasswordFormComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: '**',
    redirectTo: 'home'
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { useHash: true }), 
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    DxDataGridModule, 
    DxFormModule,
    DxFileUploaderModule,
    DxToolbarModule,
    DxSelectBoxModule, 
    DxTemplateModule,
    DxTabPanelModule,
    DxCheckBoxModule,
    DxRadioGroupModule,
    DxPopupModule, 
    DxButtonModule,
    DxLoadPanelModule,
    DxBoxModule,
    DxResponsiveBoxModule,
    DxToolbarModule,
    DxTagBoxModule,
    DxTextBoxModule,
    DxTextAreaModule,
    DxLoadPanelModule,
    DxDrawerModule,
    DxToastModule,
    DxPivotGridModule,
    DxSchedulerModule,
    DxButtonGroupModule,
    DxDropDownButtonModule
  ],
  providers: [AuthGuardService, HttpClient],
  exports: [RouterModule],
  declarations: [
    HomeComponent, 
    ProfileComponent, 
    TasksComponent,
    ReportPur12Component, 
    ReportPur3Component, 
    Pur12Component,
    Pur3ControlDomesticComponent,  
    Pur3ControlOverseaComponent, 
    Pur3PoIssueComponent, 
    Pur3PuChampComponent,
    Pur3EvalioComponent,
    Pur3ShotLTComponent,
    Pur3DelayDomesticComponent,
    Pur3DelayOverseaComponent,
    Reason12Component,
    Reason3Component,
    ProgressPur12Component
  ]
})
export class AppRoutingModule { }