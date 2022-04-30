import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent } from 'devextreme-angular';
import notify from 'devextreme/ui/notify';
import { Service } from 'src/app/shared/services';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}
@Component({
  selector: 'app-input-dl3-delay-domestic',
  templateUrl: './input-dl3-delay-domestic.component.html',
  styleUrls: ['./input-dl3-delay-domestic.component.scss'],
  providers: [Service]
})
export class InputDl3DelayDomesticComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  DelayDomestic: any[] = [];
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  items: any[] | undefined;
  productsStore: any;
  season_response: string[]  = ['D1 : 【Supplier】 Delivery ontime but invoice mistake.',
  'D2 : 【Supplier】 No delivery.',
  'D3 : 【Supplier】 Goods NG ',
  'D4 : 【Supplier】 No stock.',
  'D5 : 【Supplier】 Other.  (Please input the reason)',
  'D6 : 【CPT】 Waiting receive.',
  'D7 : 【CPT】 Other.  (Please input the reason)',
  'D8 : 【Buyer】 Other  (Please input the reason)',
  'D9 : 【Requester】 Other  (Please input the reason)'];
  
  constructor(public apiPUR: Service) {
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
      value: this.dateupOptions[0],
      onValueChanged: (args: { value: number; }) => {

      },
    };
   }

  ngOnInit(): void {
  }
  
  async getsubject(){ 
    let data = await this.apiPUR.sv_getreason("Input_reasonpur3/get_subject_delay_domestic");
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
     let data = await this.apiPUR.sv_post_paramEUC("Input_reasonpur3/get_delay_domestic_row","?sbj=" + sbj);
     this.DelayDomestic = data;
   }
  onExporting(e: any) {
    console.log('onExporting',e)
  }
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }
}
