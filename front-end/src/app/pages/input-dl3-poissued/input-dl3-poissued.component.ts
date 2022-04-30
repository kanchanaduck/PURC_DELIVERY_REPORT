import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent } from 'devextreme-angular';
import notify from 'devextreme/ui/notify';
import { Service } from 'src/app/shared/services';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-input-dl3-poissued',
  templateUrl: './input-dl3-poissued.component.html',
  styleUrls: ['./input-dl3-poissued.component.scss'],
  providers: [Service]
})
export class InputDl3PoissuedComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  POIssue:  any[] = [];
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  columnDefs: any;
  insfor: any = 0;
  constructor(service: Service, public apiPUR: Service) {
  // this.POIssue = POissueGrid;
  this.getsubject();
  this.refreshButtonOptions = {
      icon: 'refresh',
      onClick: () => {
        notify('Refresh button has been clicked!');
      },
    };
    
    this.selectBoxOptions = {
      width: 240,
      items: this.dateupOptions,
      // valueExpr: 'id',
      // displayExpr: 'text',
      value: this.dateupOptions[0],
      onValueChanged: (args: { value: number; }) => {
     
      },
    };
   }
   calculateCellValue(data: any) {
    console.log('this.calculateCellValue : ', data)
  }
  async getsubject(){ 
    let data = await this.apiPUR.sv_getreason("Input_reasonpur3/get_subject_po");
    console.log(data)
     this.dateupOptions = data;
     this.getdata(this.dateupOptions[0]);
     this.selectBoxOptions = {
       width: 240,
       items: this.dateupOptions,
       value: this.dateupOptions[0],
       onValueChanged: (e: any) => {
      this.getdata(e.value);
       },
     };
   }
  async getdata(sbj: string){ 
     let data = await this.apiPUR.sv_post_paramEUC("Input_reasonpur3/get_po_row","?sbj=" + sbj);
     this.POIssue = data;
   }
  onCellPrepared(e: any) {
    if(e.rowType === "data" && e.column.dataField === "check") {
        e.cellElement.style.color = e.data.check !== "0" && e.data.standard_unit_price_code === 'N1' ? "red" : "black";
      }
  }
  onEditorPreparing(e: any) {
    console.log('this.onEditorPreparing : ', e)
  }
  ngOnInit(): void {

  
  }
  onExporting(e: any) {
    console.log('onExporting',e)
  }
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }
  cellSt_CheckStyles(text: string){
    
    console.log("cellfcheck : ",text , this.insfor)
    var classList = '';
    if(text !== '0'){
      classList = 'cellcheck'; 
    }else{
      classList = 'cellchecknormal';
    }
    this.insfor = this.insfor + 1
    return classList;
    }
}
