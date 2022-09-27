import { HttpClient } from '@angular/common/http';
import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent } from 'devextreme-angular';
import CustomStore from 'devextreme/data/custom_store';
import notify from 'devextreme/ui/notify';
import { ApiService } from 'src/app/shared/services/api.service';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}
@Component({
  selector: 'app-pur3-delay-domestic',
  templateUrl: './pur3-delay-domestic.component.html',
  styleUrls: ['./pur3-delay-domestic.component.scss'],
  providers: [ApiService]
})
export class Pur3DelayDomesticComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  DelayDomestic: any;
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  items: any[] | undefined;
  productsStore: any;
  reason_delay_domestic: any;
  subject: any;
  
  constructor(public service: ApiService, private http: HttpClient) {
  
    this.subject = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => this.service.sendRequest(`PUR3/DelayDomestic/Subject`)
    });

    this.reason_delay_domestic = new CustomStore({
      key: 'id',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => this.service.sendRequest(`Reason/DelayDomestic`),
      insert: (values) => this.service.sendRequest(`Reason/DelayDomestic`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/DelayDomestic/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/DelayDomestic/${key}`, 'DELETE'),
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

  ngOnInit(): void {
  }
  
  async getdata(subject: string){ 
    this.DelayDomestic = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`PUR3/DelayDomestic?subject=${subject}`),
      update: (key, values) => this.service.sendRequest(`PUR3/DelayDomestic/${key}`, 'PUT', values),
    });
  }

  onExporting(e: any) {
    console.log('onExporting',e)
  }
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }
}
