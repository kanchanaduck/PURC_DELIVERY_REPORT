import { CommonModule } from '@angular/common';
import { Component, NgModule, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { DxFormModule } from 'devextreme-angular/ui/form';
import { DxLoadIndicatorModule } from 'devextreme-angular/ui/load-indicator';
import notify from 'devextreme/ui/notify';
import { AuthService } from '../../services';
import { ApiService } from '../../services/api.service';

import { DxBoxModule } from 'devextreme-angular';
@Component({
  selector: 'app-change-passsword-form',
  templateUrl: './change-password-form.component.html',
  styleUrls: ['./change-password-form.component.scss']
})
export class ChangePasswordFormComponent implements OnInit {
  loading = false;
  formData: any = {};
  recoveryCode: string;

  constructor(private authService: AuthService, public service: ApiService,
    private router: Router, private route: ActivatedRoute) { }

  ngOnInit() {
  }

  async onSubmit(e) {
    e.preventDefault();
    // const { current_password } = this.formData;
    // this.loading = true;
    // let username = '014496'
    // let new_password = '014496'

    const result = await this.authService.changePassword(this.formData);
    this.loading = false;

    if (result.isOk) {
      this.service.show_success()
      this.router.navigate(['/home']);
    } else {
      notify(result.message, 'error', 2000);
    }
  }

  confirmPassword = (e: { value: string }) => {
    console.log(this.formData)
    return e.value === this.formData.new_password;
  }
}
@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    DxFormModule,
    DxBoxModule,
    DxLoadIndicatorModule
  ],
  declarations: [ ChangePasswordFormComponent ],
  exports: [ ChangePasswordFormComponent ]
})
export class ChangePasswordFormModule { }
