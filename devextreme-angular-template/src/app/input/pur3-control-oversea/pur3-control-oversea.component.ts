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
  selector: 'app-pur3-control-oversea',
  templateUrl: './pur3-control-oversea.component.html',
  styleUrls: ['./pur3-control-oversea.component.scss'],
  providers: [ApiService]
})
export class Pur3ControlOverseaComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  Oversea:  any;
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  subject: CustomStore<any, any>;

  constructor(public service: ApiService, private http: HttpClient) {

    this.subject = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
        return this.http.get(`${environment.api}PUR3/ControlOversea/Subject`)
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
  ngOnInit(): void {
  }
   async getdata(subject: string){ 
    this.Oversea = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`PUR3/ControlOversea?subject=${subject}`),
    });
   }
  onExporting(e: any) {
    console.log('onExporting',e)
  }

}