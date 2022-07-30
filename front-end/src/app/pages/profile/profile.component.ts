import { Component, enableProdMode } from '@angular/core';
import axios from 'axios';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpParams } from '@angular/common/http';
import CustomStore from 'devextreme/data/custom_store';
import DataSource from "devextreme/data/data_source";
import { formatDate } from 'devextreme/localization';
import { lastValueFrom } from 'rxjs';

if (environment.production) {
  enableProdMode();
}

@Component({
  templateUrl: 'profile.component.html',
  styleUrls: [ './profile.component.scss' ]
})

export class ProfileComponent {
  employee: any;
  colCountByScreen: object;
  users: any = [];
  roles: any = ['Admin', 'PURC', 'PUR1', 'PUR2', 'PUR3', 'PDC'];
  dataSource: any;
  refreshModes: string[];

  refreshMode: string;
  requests: string[] = [];

  constructor(private http: HttpClient) {
    this.refreshMode = 'reshape';
    this.refreshModes = ['full', 'reshape', 'repaint'];
    this.employee = {
      Picture: '010589',
    };


    this.colCountByScreen = {
      xs: 1,
      sm: 2,
      md: 3,
      lg: 4
    };

    this.users = new CustomStore({
      key: 'username',
      load: () => this.sendRequest(`${environment.api}User`),
      insert: (values) => this.sendRequest(`${environment.api}User`, 'POST', {
        "username": values.username,
        "roles": values.role
      }),
      update: (key, values) => this.sendRequest(`${environment.api}User/${key}`, 'PUT', {
        "username": values.username,
        "roles": values.role
      }),
      remove: (key) => this.sendRequest(`${environment.api}User/${key}`, 'DELETE'),
    });


    console.log(this.users)

  }
  sendRequest(url: string, method = 'GET', data: any = {}): any {
    this.logRequest(method, url, data);

    const httpParams = new HttpParams({ fromObject: data ,});
    const httpOptions = { withCredentials: false, body: httpParams , dataType: "json"};
    let result: any;

    switch (method) {
      case 'GET':
        result = this.http.get(url, httpOptions);
        break;
      case 'PUT':
        result = this.http.put(url, data, httpOptions);
        break;
      case 'POST':
        result = this.http.post(url, data, httpOptions);
        break;
      case 'DELETE':
        result = this.http.delete(url, httpOptions);
        break;
    }

    return lastValueFrom(result)
      .then(
        (data: any) => ( method === 'GET' ? data : data) 
        )
      .catch((e: any) => {
        throw e && e.error && e.error.Message;
      });
  }

  logRequest(method: string, url: string, data: object): void {
    // const args = Object.keys(data || {}).map((key) => `${key}=${data[key]}`).join(' ');

    const time = formatDate(new Date(), 'HH:mm:ss');

    // this.requests.unshift([time, method, url.slice(URL.length), args].join(' '));
  }

  clearRequests() {
    this.requests = [];
  }

  ngOnInit() {
    // this.get_centers()
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
  
  get_centers(){
    let self = this
    axios.get(`${environment.api}User`)
    .then(function(response: any){
      self.users = response.data;
    })
    ;
  }

  register(){
    let self = this
    axios.post(`${environment.api}User`, { username: "011112"})
    .then(function(response: any){
      console.log("OK")
    })
    .catch(function(e){
      console.log(e)
    })
    ;
  }

  click = (e: any) => {
    alert("1234")
    alert(e)
    console.log(e)
  };
}

