import { HttpClient } from '@angular/common/http';
import { Component, enableProdMode, OnInit } from '@angular/core';
import CustomStore from 'devextreme/data/custom_store';
import notify from 'devextreme/ui/notify';
import { ApiService } from 'src/app/shared/services/api.service';
import { environment } from 'src/environments/environment';
import * as AspNetData from 'devextreme-aspnet-data-nojquery';
import DataSource from 'devextreme/data/data_source';
import { Settings } from 'src/app/shared/services/setting';

// if (!/localhost/.test(document.location.host)) {
//   enableProdMode();
// }

if (environment.production) {
  enableProdMode();
}
@Component({
  selector: 'app-progress-pur12',
  templateUrl: './progress-pur12.component.html',
  styleUrls: ['./progress-pur12.component.scss']
})
export class ProgressPur12Component implements OnInit {

  progressiveDomestic: any;
  progressiveOversea: any;
  selectBoxOptions: any;
  monthlyOptions: any;
  monthlyData: any;
  this_month: string = `${new Date().getFullYear()}${('0' + (new Date().getMonth()+1)).slice(-2)}`


  constructor(public service: ApiService, private http: HttpClient ) { 

    this.getdata(this.this_month);

    this.monthlyData = new CustomStore({
      load: () => {
          return this.http.get(`${environment.api}Index/Monthly`, Settings.headers)
              .toPromise()
              .then(result => {
                return result;
              })
              .catch(() => { throw 'Data loading error' });
      }
    });

    this.monthlyOptions = {
      width: 240,
      dataSource: this.monthlyData,
      value: this.monthlyData[0],
      onValueChanged: (e: any) => {
        console.log("onValueChanged",e.value);
        this.getdata(e.value);
      },
    };


  }

  getdata(monthly:string){
    this.progressiveDomestic = new CustomStore({
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Domestic/DailyProgressive?monthly=${monthly}`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });
    this.progressiveOversea = new CustomStore({
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Oversea/DailyProgressive?monthly=${monthly}`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });
  }

  onCellPrepared (e: any) {
    console.log('onCellPrepared',e);
    if (e.rowType == "detailAdaptive") {
        e.cellElement.addClass("adaptiveRowStyle");
    }
  }

  onMonthlyChanged (e: any) {
    alert(e.value)
  }

  itemClick($event: any) {
    throw new Error('Method not implemented.');
    }
    customizeColumns (cellInfo: any) {
      console.log('customizeColumns',cellInfo);
      return cellInfo.value + "$";
  }

  cellSt_CheckStyles(text: any){
    var classList = '';
    if(text == 'Completed'){
      classList = 'stcomplete'; 
    }else if(text == 'Over Lead time'){
      classList = 'stovertime';
    }
    else{
      classList = 'stwait';
    }
    return classList;
  }
    ngOnInit(): void {
    }
  }