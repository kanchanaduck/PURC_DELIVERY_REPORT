import { HttpClient } from '@angular/common/http';
import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent } from 'devextreme-angular';
import CustomStore from 'devextreme/data/custom_store';
import notify from 'devextreme/ui/notify';
import { ApiService } from 'src/app/shared/services/api.service';
import { environment } from 'src/environments/environment';
@Component({
  selector: 'app-pur3-po-issue',
  templateUrl: './pur3-po-issue.component.html',
  styleUrls: ['./pur3-po-issue.component.scss'],
  providers: [ApiService]
})
export class Pur3PoIssueComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  POIssue:  any;
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  columnDefs: any;
  insfor: any = 0;
  subject: CustomStore<any, any>;
  constructor(public service: ApiService, private http: HttpClient) {
    this.subject = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}PUR3/POIssue/Subject`)
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
   calculateCellValue(data: any) {
    console.log('this.calculateCellValue : ', data)
  }

  async getdata(subject: string){ 
     this.POIssue = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`PUR3/POIssue?subject=${subject}`),
    });
   }
  ngOnInit(): void {

  
  }
  onExporting(e: any) {
    console.log('onExporting',e)
  }
}
