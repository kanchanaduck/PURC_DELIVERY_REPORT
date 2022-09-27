import { HttpClient } from '@angular/common/http';
import { Component, enableProdMode, OnInit } from '@angular/core';
import CustomStore from 'devextreme/data/custom_store';
import notify from 'devextreme/ui/notify';
import { ApiService } from 'src/app/shared/services/api.service';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-pur3-evalio',
  templateUrl: './pur3-evalio.component.html',
  styleUrls: ['./pur3-evalio.component.scss']
})
export class Pur3EvalioComponent implements OnInit {
  evalio: any;
  selectedItemKeys: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  reason_evalio: any;
  subject: any;

  constructor(public service: ApiService, private http: HttpClient) { 
    this.subject = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => this.service.sendRequest(`PUR3/ControlEvalio/Subject`)
    });

    this.reason_evalio = new CustomStore({
      key: 'id',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => this.service.sendRequest(`Reason/ControlEvalio`),
      insert: (values) => this.service.sendRequest(`Reason/ControlEvalio`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/ControlEvalio/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/ControlEvalio/${key}`, 'DELETE'),
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
  onExporting(e: any) {
    console.log('onExporting',e)
  }
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }

  async getdata(subject: string){ 
    this.evalio = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`PUR3/ControlEvalio?subject=${subject}`),
      update: (key, values) => this.service.sendRequest(`PUR3/ControlEvalio/${key}`, 'PUT', values),
    });
  }

  editable(rowData: any, value: any): boolean {
    return rowData.delay < 0
  }

}
