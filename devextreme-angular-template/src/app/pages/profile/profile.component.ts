import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import axios from 'axios';
import CustomStore from 'devextreme/data/custom_store';
import notify from 'devextreme/ui/notify';
import { ApiService } from 'src/app/shared/services/api.service';
import { Settings } from 'src/app/shared/services/setting';
import { environment } from 'src/environments/environment';
@Component({
  selector: 'app-profile',
  templateUrl: 'profile.component.html',
  styleUrls: [ './profile.component.scss' ],
  // providers: [ ApiService ],
})

export class ProfileComponent {
  employee: any;
  colCountByScreen: object;
  users: any = [];
  roles: any = ['Buyer', 'Other', 'Leader', 'Manager','PURC'];
  dataSource: any;
  refreshModes: string[];

  refreshMode: string;
  requests: string[] = [];

  is_purc: boolean = false;

  constructor(public service: ApiService, private http: HttpClient) {
    this.refreshMode = 'reshape';
    this.refreshModes = ['full', 'reshape', 'repaint'];

    this.is_purc = this.service.is_purc()

    /* this.roles = new CustomStore({
      key: 'id',
      load: () => service.sendRequest(`Roles`),
    }); */

    console.log(this.roles)

    this.colCountByScreen = {
      xs: 1,
      sm: 2,
      md: 3,
      lg: 4
    };

    this.users = new CustomStore({
      key: 'username',
      load: () => service.sendRequest(`User`),
      insert: (values) => service.sendRequest(`Register`, 'POST', {
        "username": values.username,
        "roles": values.roles
      }),
      update: (key, values) => service.sendRequest(`User/${key}`, 'PUT', {
        "username": values.username,
        "roles": values.roles
      }),
      remove: (key) => service.sendRequest(`User/${key}`, 'DELETE'),
    });

  }

  clearRequests() {
    this.requests = [];
  }

  ngOnInit() {

  }

  onSaving(e: any) {
    const change = e.changes[0];
    if (change) {
      e.cancel = true;
      e.promise = this.processSaving(change);
    }
  }

  async processSaving(change: any) {
    console.log(change)
    // this.isLoading = true;

    /* try {
      await this.service.saveChange(change);
      this.editRowKey = null;
      this.changes = [];
    } finally {
      this.isLoading = false;
    } */
  }

  async reset_password(e: any) {
    try {
      await axios.put(`${environment.api}User/ResetPassword/${e.row.data.username}`, null, Settings.headers)
      notify("Complete!", "success");
    } 
    catch (error: any) {
      var text = typeof error.response.data === 'object'? error.response.data.title:error.response.data
      notify("Error! "+text, "error");
    }
    e.event.preventDefault();
  }
}
