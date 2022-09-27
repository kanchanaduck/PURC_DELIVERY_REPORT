import { HttpClient } from '@angular/common/http';
import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent} from 'devextreme-angular';
import CustomStore from 'devextreme/data/custom_store';
import { ApiService } from 'src/app/shared/services/api.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-pur3-control-domestic',
  templateUrl: './pur3-control-domestic.component.html',
  styleUrls: ['./pur3-control-domestic.component.scss'],
})

export class Pur3ControlDomesticComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  @ViewChild("griddomestic") dataGridDomestic!: DxDataGridComponent;
  Domestic: CustomStore |  any[] = [];
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  subject: any;
  
  constructor(public service: ApiService, private http: HttpClient ) {
    // this.getsubject();

    this.subject = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}PUR3/ControlDomestic/Subject`)
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
    this.Domestic = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`PUR3/ControlDomestic?subject=${subject}`),
    });
    
  }

  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }
  onExporting(e: any) {
    console.log('onExporting',e)
    // const workbook = new Excel.Workbook();
    // const worksheet = workbook.addWorksheet('Employees');

    // exportDataGrid({
    //   component: e.component,
    //   worksheet,
    //   autoFilterEnabled: true,
    // }).then(() => {
    //   workbook.xlsx.writeBuffer().then((buffer) => {
    //     fs.saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'DataGrid.xlsx');
    //   });
    // });
    // e.cancel = true;

    // const workbook = new Excel.Workbook();    
    // const worksheet = workbook.addWorksheet('Main sheet');
    // exportPivotGrid({
    //     component: e.component,
    //     worksheet: worksheet
    // }).then(function() {
    //     workbook.xlsx.writeBuffer()
    //         .then(function(buffer: BlobPart) {
    //           fs.saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'PivotGrid.xlsx');
    //         });
    // });
    // e.cancel = true; 

  }
 
}
