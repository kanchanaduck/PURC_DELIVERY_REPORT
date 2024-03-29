import { Component, NgModule, Input } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DxListModule } from 'devextreme-angular/ui/list';
import { DxContextMenuModule } from 'devextreme-angular/ui/context-menu';
import { AuthService } from '../../services';
import { Settings } from '../../services/setting';

@Component({
  selector: 'app-user-panel',
  templateUrl: 'user-panel.component.html',
  styleUrls: ['./user-panel.component.scss']
})

export class UserPanelComponent {
  @Input()
  menuItems: any;

  @Input()
  menuMode: string;

  @Input()
  user: any;
  user_img: string = `url(${Settings.IMG_GAROON}.JPG)`

  constructor(private authService: AuthService) {
    this.authService.getUser().then((e) => {
      this.user = e.data
      // console.log(e)
    });
    console.log(this.user_img)
  }
}

@NgModule({
  imports: [
    DxListModule,
    DxContextMenuModule,
    CommonModule
  ],
  declarations: [ UserPanelComponent ],
  exports: [ UserPanelComponent ]
})
export class UserPanelModule { }
