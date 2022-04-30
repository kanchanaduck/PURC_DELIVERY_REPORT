import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent} from 'devextreme-angular';
import CustomStore from 'devextreme/data/custom_store';
import DataSource from 'devextreme/data/data_source';
import notify from 'devextreme/ui/notify';
import { AuthService, Service } from 'src/app/shared/services';
import { environment } from 'src/environments/environment';


// if (!/localhost/.test(document.location.host)) {
//   enableProdMode();
// }
if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-input-dl3-domestic',
  templateUrl: './input-dl3-domestic.component.html',
  styleUrls: ['./input-dl3-domestic.component.scss'],
  providers: [Service]
  // providers: [AuthService]
})
export class InputDl3DomesticComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  @ViewChild("griddomestic") dataGridDomestic!: DxDataGridComponent;
  // Domestic: ControlDomestic[];
  // Domestic:  any[] = [];
  Domestic: CustomStore |  any[] = [];
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  
  constructor( service: Service,
    public apiPUR: Service) {
    this.getsubject();
   }
  ngOnInit(): void {
  }
   async getsubject(){ 
   let data = await this.apiPUR.sv_getreason("Input_reasonpur3/get_subject_cnt_domestic");
    this.dateupOptions = data;
    this.getdata(this.dateupOptions[0]);
    this.selectBoxOptions = {
      width: 240,
      items: this.dateupOptions,
      value: this.dateupOptions[0],
      onValueChanged: (e: any) => {
     console.log("onValueChanged",e.value);
     this.getdata(e.value);
      },
    };
  }
  async getdata(sbj: string){
    let that = this 
    // let data = await this.apiPUR.sv_post_paramEUC("Input_reasonpur3/get_domestic_row","?sbj=" + sbj);
    // this.Domestic = data;
    console.log('getdata');
    this.Domestic = new CustomStore({
      load: async () => {
        return await this.apiPUR.sv_post_paramEUC("Input_reasonpur3/get_domestic_row","?sbj=" + sbj)
          .catch(() => { throw 'Data loading error' });
        }
    })
    that.dataGridDomestic.instance.refresh(); 
    
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
