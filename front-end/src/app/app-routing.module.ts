import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginFormComponent, ResetPasswordFormComponent, CreateAccountFormComponent, ChangePasswordFormComponent } from './shared/components';
import { AuthGuardService } from './shared/services';

import { HomeComponent } from './pages/home/home.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { TasksComponent } from './pages/tasks/tasks.component';

import { CreateComponent } from './pages/create/create.component';
import { ReportPur12Component } from './pages/report-pur12/report-pur12.component';
import { DailyProgressComponent } from './pages/daily-progress/daily-progress.component';
import { FollowReasonComponent } from './pages/follow-reason/follow-reason.component';
import { ReportPur3Component } from './pages/report-pur3/report-pur3.component';
import { OtherDeptComponent } from './pages/other-dept/other-dept.component';
import { InputReasonComponent } from './pages/input-reason/input-reason.component';
import { ContractCenterComponent } from './pages/contract-center/contract-center.component';
import { HelpCenterComponent } from './pages/help-center/help-center.component';
import { InputReasonPur12Component } from './pages/input-reason-pur12/input-reason-pur12.component';
import { InputDl3DomesticComponent } from './pages/input-dl3-domestic/input-dl3-domestic.component';
import { InputDl3OverseaComponent } from './pages/input-dl3-oversea/input-dl3-oversea.component';
import { InputDl3PoissuedComponent } from './pages/input-dl3-poissued/input-dl3-poissued.component';
import { InputDl3PuchampComponent } from './pages/input-dl3-puchamp/input-dl3-puchamp.component';
import { InputDl3EvalioComponent } from './pages/input-dl3-evalio/input-dl3-evalio.component';
import { InputDl3ShotLTComponent } from './pages/input-dl3-shot-lt/input-dl3-shot-lt.component';
import { InputDl3DelayDomesticComponent } from './pages/input-dl3-delay-domestic/input-dl3-delay-domestic.component';
import { InputDl3DelayOverseaComponent } from './pages/input-dl3-delay-oversea/input-dl3-delay-oversea.component';
import { CheckLeaderComponent } from './pages/check-leader/check-leader.component';
import { CheckManagerComponent } from './pages/check-manager/check-manager.component';
import { CheckOtherdeptComponent } from './pages/check-otherdept/check-otherdept.component';
import { CheckPurcComponent } from './pages/check-purc/check-purc.component';

import { 
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
  DxFormModule, 
  DxDataGridModule, 
  DxSelectBoxModule, 
  DxTagBoxModule,
  DxTextBoxModule,
  DxTextAreaModule,
  DxResponsiveBoxModule
} from 'devextreme-angular';
import { CommonModule } from '@angular/common';


const routes: Routes = [
  {
    path: 'pages/check-purc',
    component: CheckPurcComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/check-otherdept',
    component: CheckOtherdeptComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/check-manager',
    component: CheckManagerComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/check-leader',
    component: CheckLeaderComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-dl3-delay-oversea',
    component: InputDl3DelayOverseaComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-dl3-delay-domestic',
    component: InputDl3DelayDomesticComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-dl3-shot-lt',
    component: InputDl3ShotLTComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-dl3-evalio',
    component: InputDl3EvalioComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-dl3-puchamp',
    component: InputDl3PuchampComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-dl3-poissued',
    component: InputDl3PoissuedComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-dl3-oversea',
    component: InputDl3OverseaComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-dl3-domestic',
    component: InputDl3DomesticComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-reason-pur12',
    component: InputReasonPur12Component,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/help-center',
    component: HelpCenterComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/contract-center',
    component: ContractCenterComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/input-reason',
    component: InputReasonComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/other-dept',
    component: OtherDeptComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/report-pur3',
    component: ReportPur3Component,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/follow-reason',
    component: FollowReasonComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/daily-progress',
    component: DailyProgressComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/report-pur12',
    component: ReportPur12Component,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'pages/create',
    component: CreateComponent,
    canActivate: [ AuthGuardService ]
  },
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
    path: 'change-password/:recoveryCode',
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
    DxResponsiveBoxModule
  ],
  providers: [AuthGuardService],
  exports: [RouterModule],
  declarations: [
    HomeComponent, 
    ProfileComponent,
    TasksComponent,
    CreateComponent, 
    ReportPur12Component,
    DailyProgressComponent, 
    FollowReasonComponent, 
    ReportPur3Component, 
    OtherDeptComponent, 
    InputReasonComponent, 
    ContractCenterComponent, 
    HelpCenterComponent, 
    InputReasonPur12Component, 
    InputDl3DomesticComponent, 
    InputDl3OverseaComponent, 
    InputDl3PoissuedComponent, 
    InputDl3PuchampComponent,
    InputDl3EvalioComponent,
    InputDl3ShotLTComponent,
    InputDl3DelayDomesticComponent,
    InputDl3DelayOverseaComponent,
    CheckLeaderComponent, 
    CheckManagerComponent, 
    CheckOtherdeptComponent, 
    CheckPurcComponent]
})
export class AppRoutingModule { }
