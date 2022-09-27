import { Component } from '@angular/core';
import CustomStore from 'devextreme/data/custom_store';
import notify from 'devextreme/ui/notify';
import { ApiService } from 'src/app/shared/services/api.service';
import { environment } from 'src/environments/environment';
import * as AspNetData from 'devextreme-aspnet-data-nojquery'
import { HttpClient } from '@angular/common/http';
import { createStore } from 'devextreme-aspnet-data-nojquery';
import DevExpress from 'devextreme';
import DataSource from "devextreme/data/data_source";
import { Settings } from 'src/app/shared/services/setting';

@Component({
  templateUrl: 'home.component.html',
  styleUrls: [ './home.component.scss' ]
})


export class HomeComponent {

  _user: any;

  dataSource: any;
  selectBoxOptions: any;
  createYearButtonOptions: any;
  years: any = [2022];

  kpi: any;
  this_year: number = new Date().getFullYear();
  next_year: number;
  month: number = new Date().getMonth()+1;
  year: number;

  focus_month: Date;

  refreshModes: string[];
  refreshMode: string;

  kpi_pur1: any;
  kpi_pur2: any;
  kpi_pur3: any;

  is_purc: boolean = false;


  constructor(public service: ApiService, private http: HttpClient) {
    
    this.is_purc = this.service.is_purc()

    this.refreshMode = 'reshape';
    this.refreshModes = ['full', 'reshape', 'repaint'];

    this.next_year = this.this_year+1;
    this.focus_month = new Date(this.this_year, this.month-2, 1)

    this.years = new CustomStore({
      key: 'year',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}KPI/Years`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      },
    });

    this.year = this.this_year
    this.get_kpi()

    this.selectBoxOptions = {
      width: 160,
      dataSource: this.years,
      value: this.year,
      onValueChanged: (e: any) => {
        console.log("onValueChanged",e.value);
        this.year = e.value;
        this.get_kpi()
      },
    };

    this.createYearButtonOptions = {
      icon: 'add',
      text: `Create KPI ${this.next_year}`,
      type: 'success',
      visible: this.is_purc, //&& this.month==12,
      onClick: () => {
        this.service.sendRequest(`KPI/Create/${this.next_year}`)
      },
    };
  }

  get_kpi(){
    this.kpi_pur1 = new CustomStore({
      key: ['monthly', 'dept'],
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}KPI?year=${this.year}&dept=PUR1`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      },
      update: (key, values) => {
          return this.http.put(`${environment.api}KPI/?monthly=${key.monthly}&dept=${key.dept}`, values, Settings.headers)
              .toPromise()
              .catch((error: any) => {console.log(error); throw error.error.errors.kpi[0] });
      }
    });

    this.kpi_pur2 = new CustomStore({
      key: ['monthly', 'dept'],
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}KPI?year=${this.year}&dept=PUR2`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      },
      update: (key, values) => {
          return this.http.put(`${environment.api}KPI/?monthly=${key.monthly}&dept=${key.dept}`, values, Settings.headers)
              .toPromise()
              .catch((error: any) => {console.log(error); throw error.error.errors.kpi[0] });
      }
    });

    this.kpi_pur3 = new CustomStore({
      key: ['monthly', 'dept'],
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}KPI?year=${this.year}&dept=PUR3`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      },
      update: (key, values) => {
          return this.http.put(`${environment.api}KPI/?monthly=${key.monthly}&dept=${key.dept}`, values, Settings.headers)
              .toPromise()
              .catch((error: any) => {console.log(error); throw error.error.errors.kpi[0] });
      }
    });

  }

}