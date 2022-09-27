import { HttpClient } from '@angular/common/http';
import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent } from 'devextreme-angular';
import CustomStore from 'devextreme/data/custom_store';
import { ApiService } from 'src/app/shared/services/api.service';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-pur3-delay-oversea',
  templateUrl: './pur3-delay-oversea.component.html',
  styleUrls: ['./pur3-delay-oversea.component.scss'],
  providers: [ApiService]
})
export class Pur3DelayOverseaComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  DelayOversea: any;
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  reason_delay_oversea: any;
  subject: any;
  constructor(public service: ApiService, private http: HttpClient) { 

    this.subject = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
        return this.http.get(`${environment.api}PUR3/DelayOversea/Subject`)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });

    this.reason_delay_oversea = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Reason/DelayOversea`)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });

    this.selectBoxOptions = {
      width: 240,
      dataSource: this.subject,
      onValueChanged: (e: any) => {
        console.log("onValueChanged",e.value);
        this.getdata(e.value);
      },
    }; 
  }
  async getdata(subject: string){ 
    this.DelayOversea = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`PUR3/DelayOversea?subject=${subject}`),
      update: (key, values) => this.service.sendRequest(`PUR3/DelayOversea/${key}`, 'PUT', values),
    });
  }
  ngOnInit(): void {
  }
  onExporting(e: any) {
    console.log('onExporting',e)
  }
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }
}