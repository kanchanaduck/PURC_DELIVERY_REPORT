import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent } from 'devextreme-angular';
import notify from 'devextreme/ui/notify';
import { Service } from 'src/app/shared/services';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-input-dl3-delay-oversea',
  templateUrl: './input-dl3-delay-oversea.component.html',
  styleUrls: ['./input-dl3-delay-oversea.component.scss'],
  providers: [Service]
})
export class InputDl3DelayOverseaComponent implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  Delayoversea: any[] = [];
  selectedItemKeys: any[] = [];
  dateupOptions: any[] = [];
  selectBoxOptions: any;
  refreshButtonOptions: any;
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
    // this.Delayoversea = DelayOverseaGrid;
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
  async getsubject(){ 
    let data = await this.apiPUR.sv_getreason("Input_reasonpur3/get_subject_delay_oversea");
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
     let data = await this.apiPUR.sv_post_paramEUC("Input_reasonpur3/get_delay_oversea_row","?sbj=" + sbj);
     this.Delayoversea = data;
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
export class ControlDelayOversea {
  ID!: number;
  Status!: string;
  PO_Number!: string;
  PO_Line!: string;
  PO_Shipment!: string;
  req_no!: string;
  req_details!: string;
  pur_incharge!: string;
  Supplier!: string;
  Supplier_site!: string;
  Item_Des!: string;
  maker!: string;
  type!: string;
  Price!: string;
  Currency!: string;
  pur_order_qty!: string;
  delivered_qty!: string;
  balanced_qty!: string;
  balanced_order_qty!: string;
  unit!: string;
  inspection!: string;
  Order_Date!: string;
  shipping_date!: string;
  Promised_Date!: string;
  Today_date!: string;
  Delay!: string;
  Resp_Supp_cpt!: string;
  Reason!: string;
  transportation!: string;
  Requisitioner!: string;
  request_dept!: string;
  request_Email!: string;
  date_up!: string;
}
const DelayOverseaGrid: ControlDelayOversea[] = [{
  ID: 1 ,
  Status: 'Approved' ,
  PO_Number: '251700001326' ,
  PO_Line: '1' ,
  PO_Shipment: '1' ,
  req_no: '151010088086' ,
  req_details: '1' ,
  pur_incharge: 'PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA / PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA' ,
  Supplier: '7900_ใญใคใใณ๏ผฉ๏ผฎ๏ผฃ' ,
  Supplier_site: '01K' ,
  Item_Des: '4WAY LASER BEAM SWITCHING JIG 104569X12 FOR LASER WELDING MACHINE' ,
  maker: 'CANON INC.' ,
  type: '104569X12' ,
  Price: '4554000' ,
  Currency: 'JPY' ,
  pur_order_qty: '1' ,
  delivered_qty: '0' ,
  balanced_qty: '1' ,
  balanced_order_qty: '1' ,
  unit: 'PCS' ,
  inspection: 'No' ,
  Order_Date: '7/19/2021' ,
  shipping_date: '1/5/2022' ,
  Promised_Date: '1/5/2022' ,
  Today_date: '1/17/2022' ,
  Delay: '-12' ,
  Resp_Supp_cpt: '' ,
  Reason: '' ,
  transportation: 'AIR' ,
  Requisitioner: 'SANGKODMA MALISA' ,
  request_dept: 'ENGINEERING DEPT. 3' ,
  request_Email: 'malisa@mail.canon' ,
  date_up: '1/17/2022'
}, {
  ID: 4,
  Status: 'Approved' ,
  PO_Number: '251700001326' ,
  PO_Line: '1' ,
  PO_Shipment: '1' ,
  req_no: '151010088086' ,
  req_details: '2' ,
  pur_incharge: 'PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA / PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA' ,
  Supplier: '7900_ใญใคใใณ๏ผฉ๏ผฎ๏ผฃ' ,
  Supplier_site: '01K' ,
  Item_Des: '4WAY LASER BEAM SWITCHING JIG 104569X12 FOR LASER WELDING MACHINE' ,
  maker: 'CANON INC.' ,
  type: '104569X12' ,
  Price: '4554000' ,
  Currency: 'JPY' ,
  pur_order_qty: '1' ,
  delivered_qty: '0' ,
  balanced_qty: '1' ,
  balanced_order_qty: '1' ,
  unit: 'PCS' ,
  inspection: 'No' ,
  Order_Date: '7/19/2021' ,
  shipping_date: '1/5/2022' ,
  Promised_Date: '1/5/2022' ,
  Today_date: '1/17/2022' ,
  Delay: '-12' ,
  Resp_Supp_cpt: '' ,
  Reason: '' ,
  transportation: 'AIR' ,
  Requisitioner: 'SANGKODMA MALISA' ,
  request_dept: 'ENGINEERING DEPT. 3' ,
  request_Email: 'malisa@mail.canon' ,
  date_up: '1/17/2022'
}, {
  ID: 7,
  Status: 'Approved' ,
  PO_Number: '251700001357' ,
  PO_Line: '6' ,
  PO_Shipment: '1' ,
  req_no: '151010092503' ,
  req_details: '6' ,
  pur_incharge: 'PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA / PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA' ,
  Supplier: '7900_ใญใคใใณ๏ผฉ๏ผฎ๏ผฃ' ,
  Supplier_site: '01K' ,
  Item_Des: 'GF-C300 A4' ,
  maker: 'CANON INC.' ,
  type: '4044B038' ,
  Price: '8338' ,
  Currency: 'JPY' ,
  pur_order_qty: '50' ,
  delivered_qty: '0' ,
  balanced_qty: '50' ,
  balanced_order_qty: '50' ,
  unit: 'BX' ,
  inspection: 'No' ,
  Order_Date: '11/19/2021' ,
  shipping_date: '1/11/2022' ,
  Promised_Date: '1/11/2022' ,
  Today_date: '1/17/20222' ,
  Delay: '-6' ,
  Resp_Supp_cpt: '' ,
  Reason: '' ,
  transportation: 'OCEAN' ,
  Requisitioner: 'JINDAMORAKOT JAMAREE' ,
  request_dept: 'PRODUCT QUALITY ASSURANCE DEPT.' ,
  request_Email: 'jamaree@mail.canon' ,
  date_up: '1/17/2022'
}, {
  ID: 11,
  Status: 'Approved' ,
  PO_Number: '251700001304' ,
  PO_Line: '1' ,
  PO_Shipment: '1' ,
  req_no: '151010085151' ,
  req_details: '2' ,
  pur_incharge: 'PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA / PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA' ,
  Supplier: '7900_ใญใคใใณ๏ผฉ๏ผฎ๏ผฃ' ,
  Supplier_site: '01K' ,
  Item_Des: 'QUANTITY OF PULLEY PRESS FIT CONFIRMATION TOOL' ,
  maker: 'CANON INC.' ,
  type: '104569X12' ,
  Price: '4554000' ,
  Currency: 'JPY' ,
  pur_order_qty: '1' ,
  delivered_qty: '0' ,
  balanced_qty: '1' ,
  balanced_order_qty: '1' ,
  unit: 'PCS' ,
  inspection: 'No' ,
  Order_Date: '7/19/2021' ,
  shipping_date: '1/5/2022' ,
  Promised_Date: '1/5/2022' ,
  Today_date: '1/17/2022' ,
  Delay: '-12' ,
  Resp_Supp_cpt: '' ,
  Reason: '' ,
  transportation: 'AIR' ,
  Requisitioner: 'SANGKODMA MALISA' ,
  request_dept: 'ENGINEERING DEPT. 3' ,
  request_Email: 'malisa@mail.canon' ,
  date_up: '1/17/2022'
}, {
  ID: 14,
  Status: 'Approved' ,
  PO_Number: '251700001304' ,
  PO_Line: '1' ,
  PO_Shipment: '1' ,
  req_no: '151010085151' ,
  req_details: '2' ,
  pur_incharge: 'PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA / PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA' ,
  Supplier: '7900_ใญใคใใณ๏ผฉ๏ผฎ๏ผฃ' ,
  Supplier_site: '01K' ,
  Item_Des: 'QUANTITY OF PULLEY PRESS FIT CONFIRMATION TOOL' ,
  maker: 'CANON INC.' ,
  type: '104569X12' ,
  Price: '4554000' ,
  Currency: 'JPY' ,
  pur_order_qty: '1' ,
  delivered_qty: '0' ,
  balanced_qty: '1' ,
  balanced_order_qty: '1' ,
  unit: 'PCS' ,
  inspection: 'No' ,
  Order_Date: '7/19/2021' ,
  shipping_date: '1/5/2022' ,
  Promised_Date: '1/5/2022' ,
  Today_date: '1/17/2022' ,
  Delay: '-12' ,
  Resp_Supp_cpt: '' ,
  Reason: '' ,
  transportation: 'AIR' ,
  Requisitioner: 'SANGKODMA MALISA' ,
  request_dept: 'ENGINEERING DEPT. 3' ,
  request_Email: 'malisa@mail.canon' ,
  date_up: '1/17/2022'
}, {
  ID: 15,
  Status: 'Approved' ,
  PO_Number: '251700001304' ,
  PO_Line: '1' ,
  PO_Shipment: '1' ,
  req_no: '151010085151' ,
  req_details: '2' ,
  pur_incharge: 'PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA / PENSRI SAREEYA PUR3 C.PRACHINBURI THAILA' ,
  Supplier: '7900_ใญใคใใณ๏ผฉ๏ผฎ๏ผฃ' ,
  Supplier_site: '01K' ,
  Item_Des: 'MOTOR PULLEY PRESS FIT TOOL' ,
  maker: 'CANON INC.' ,
  type: '104569X12' ,
  Price: '4554000' ,
  Currency: 'JPY' ,
  pur_order_qty: '1' ,
  delivered_qty: '0' ,
  balanced_qty: '1' ,
  balanced_order_qty: '1' ,
  unit: 'PCS' ,
  inspection: 'No' ,
  Order_Date: '7/19/2021' ,
  shipping_date: '1/5/2022' ,
  Promised_Date: '1/5/2022' ,
  Today_date: '1/17/2022' ,
  Delay: '-12' ,
  Resp_Supp_cpt: '' ,
  Reason: '' ,
  transportation: 'AIR' ,
  Requisitioner: 'SANGKODMA MALISA' ,
  request_dept: 'ENGINEERING DEPT. 3' ,
  request_Email: 'malisa@mail.canon' ,
  date_up: '1/17/2022'
}];
