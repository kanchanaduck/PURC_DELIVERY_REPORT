import { Component, enableProdMode, OnInit } from '@angular/core';
import notify from 'devextreme/ui/notify';
import { environment } from 'src/environments/environment';


if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-pur3-short-lt',
  templateUrl: './pur3-short-lt.component.html',
  styleUrls: ['./pur3-short-lt.component.scss']
})
export class Pur3ShotLTComponent implements OnInit {
  shotLTDT: ControlshotLT[];
  selectedItemKeys: any[] = [];
  dateupOptions: string[] = ['02-11-2021', '02-12-2021', '02-01-2022', '14-02-2022', '18-02-2022', '19-02-2022'];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  cause_season: string[]  = ['Supplier',
   'Requester',
   'Buyer',
   'Receiving'];

  constructor() { 
    this.shotLTDT = ControlshotLTGrid;
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

  ngOnInit(): void {
  }
  onExporting(e: any) {
    console.log('onExporting',e)
  }
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }
}
export class ControlshotLT {
  ID!: number;
  reqn_no!: string;
  pur_order_no!: string;
  supp_code!: string;
  supp_name!: string;
  Supp_Site_code!: string;
  maker_name!: string;
  type!: string;
  item_code!: string;
  class_com_code!: string;
  Item_Des!: string;
  charge_to!: string;
  charge_to_name!: string;
  unit!: string;
  Order_Date!: string;
  Promised_Date!: string;
  Received_date!: string;
  rece_accep!: string;
  Check_Short_LT!: string;
  Check_Early_time_Delay!: string;
  Status!: string;
  Cause!: string;
  Department!: string;
  Reason!: string;
  stnd_price!: string;
  ord_unit_price!: string;
  pay_unit_price!: string;
  pur_req_qty!: string;
  pur_order_qty!: string;
  Rec_qty!: string;
  rec_accep_qty!: string;
  estimated!: string;
  payment_amount_Tax!: string;
  Inv_Domestic!: string;
  Dept_code_pur_req!: string;
  Dept_pur_req!: string;
  pur_in_charge!: string;
}

const ControlshotLTGrid: ControlshotLT[] = [{
  ID: 1 ,
  reqn_no: '151010093968-11' ,
  pur_order_no: '251100061060-01-01' ,
  supp_code: 'SAUC' ,
  supp_name: 'SYSTEM UPGRADE SOLUTION BKK CO.,LTD.' ,
  Supp_Site_code: '0' ,
  maker_name: 'SUS' ,
  type: 'SFB-56SS' ,
  item_code: '7B124' ,
  class_com_code: 'P0006848' ,
  Item_Des: 'SFB-56SS Hexagon Socket Head Cap Screw M6x50 (Stainless)' ,
  charge_to: '5510' ,
  charge_to_name: 'Assy1 Indirect' ,
  unit: 'PCS' ,
  Order_Date: '1/11/2022' ,
  Promised_Date: '1/12/2022' ,
  Received_date: '1/12/2022' ,
  rece_accep: '1/12/2022' ,
  Check_Short_LT: '-1' ,
  Check_Early_time_Delay: '0' ,
  Status: 'Shot L/T' ,
  Cause: 'Supplier' ,
  Department: 'SUS' ,
  Reason: 'System Error (Lead time)' ,
  stnd_price: '11.46' ,
  ord_unit_price: '11.46' ,
  pay_unit_price: '11.46' ,
  pur_req_qty: '200' ,
  pur_order_qty: '200' ,
  Rec_qty: '200' ,
  rec_accep_qty: '200' ,
  estimated: '11.46' ,
  payment_amount_Tax: '2292' ,
  Inv_Domestic: 'AP2201-0581' ,
  Dept_code_pur_req: '5505' ,
  Dept_pur_req: 'ASSEMBLY ADMINISTRATION DEPT.' ,
  pur_in_charge: 'BURANAPAN MATHAWEE' 
}, {
  ID: 4,
  reqn_no: '151010087536-03' ,
  pur_order_no: '251100056549-10-01' ,
  supp_code: 'M726' ,
  supp_name: 'MISUMI (THAILAND) CO.,LTD.' ,
  Supp_Site_code: '0' ,
  maker_name: 'OMRON' ,
  type: 'XG4C-2631' ,
  item_code: '6C1X4' ,
  class_com_code: 'P0006782' ,
  Item_Des: 'OMR XG4C' ,
  charge_to: '5330' ,
  charge_to_name: 'Engineering Dept. 3' ,
  unit: 'PCS' ,
  Order_Date: '7/5/2021' ,
  Promised_Date: '1/12/2022' ,
  Received_date: '1/5/2022' ,
  rece_accep: '1/5/2022' ,
  Check_Short_LT: '-184' ,
  Check_Early_time_Delay: '0' ,
  Status: 'Ontime' ,
  Cause: '' ,
  Department: '' ,
  Reason: '' ,
  stnd_price: '93.6' ,
  ord_unit_price: '93.6' ,
  pay_unit_price: '93.6' ,
  pur_req_qty: '10' ,
  pur_order_qty: '10' ,
  Rec_qty: '10' ,
  rec_accep_qty: '10' ,
  estimated: '93.6' ,
  payment_amount_Tax: '936' ,
  Inv_Domestic: 'LN20001763H2' ,
  Dept_code_pur_req: '5330' ,
  Dept_pur_req: 'ENGINEERING DEPT. 3' ,
  pur_in_charge: 'MUNGKHUNKARN KANOKWAN' 
}, {
  ID: 5,
  reqn_no: '151010093968-11' ,
  pur_order_no: '251100061060-01-01' ,
  supp_code: 'SAUC' ,
  supp_name: 'SYSTEM UPGRADE SOLUTION BKK CO.,LTD.' ,
  Supp_Site_code: '0' ,
  maker_name: 'SUS' ,
  type: 'SFB-56SS' ,
  item_code: '7B124' ,
  class_com_code: 'P0006848' ,
  Item_Des: 'SFB-56SS Hexagon Socket Head Cap Screw M6x50 (Stainless)' ,
  charge_to: '5510' ,
  charge_to_name: 'Assy1 Indirect' ,
  unit: 'PCS' ,
  Order_Date: '1/11/2022' ,
  Promised_Date: '1/12/2022' ,
  Received_date: '1/12/2022' ,
  rece_accep: '1/12/2022' ,
  Check_Short_LT: '-1' ,
  Check_Early_time_Delay: '0' ,
  Status: 'Shot L/T' ,
  Cause: 'Supplier' ,
  Department: 'SUS' ,
  Reason: 'System Error (Lead time)' ,
  stnd_price: '11.46' ,
  ord_unit_price: '11.46' ,
  pay_unit_price: '11.46' ,
  pur_req_qty: '200' ,
  pur_order_qty: '200' ,
  Rec_qty: '200' ,
  rec_accep_qty: '200' ,
  estimated: '11.46' ,
  payment_amount_Tax: '2292' ,
  Inv_Domestic: 'AP2201-0581' ,
  Dept_code_pur_req: '5505' ,
  Dept_pur_req: 'ASSEMBLY ADMINISTRATION DEPT.' ,
  pur_in_charge: 'BURANAPAN MATHAWEE' 
}, {
  ID: 6,
  reqn_no: '151010087536-03' ,
  pur_order_no: '251100056549-10-01' ,
  supp_code: 'M726' ,
  supp_name: 'MISUMI (THAILAND) CO.,LTD.' ,
  Supp_Site_code: '0' ,
  maker_name: 'OMRON' ,
  type: 'XG4C-2631' ,
  item_code: '6C1X4' ,
  class_com_code: 'P0006782' ,
  Item_Des: 'OMR XG4C' ,
  charge_to: '5330' ,
  charge_to_name: 'Engineering Dept. 3' ,
  unit: 'PCS' ,
  Order_Date: '7/5/2021' ,
  Promised_Date: '1/12/2022' ,
  Received_date: '1/5/2022' ,
  rece_accep: '1/5/2022' ,
  Check_Short_LT: '0' ,
  Check_Early_time_Delay: '0' ,
  Status: 'Ontime' ,
  Cause: '' ,
  Department: '' ,
  Reason: '' ,
  stnd_price: '93.6' ,
  ord_unit_price: '93.6' ,
  pay_unit_price: '93.6' ,
  pur_req_qty: '10' ,
  pur_order_qty: '10' ,
  Rec_qty: '10' ,
  rec_accep_qty: '10' ,
  estimated: '93.6' ,
  payment_amount_Tax: '936' ,
  Inv_Domestic: 'LN20001763H2' ,
  Dept_code_pur_req: '5330' ,
  Dept_pur_req: 'ENGINEERING DEPT. 3' ,
  pur_in_charge: 'MUNGKHUNKARN KANOKWAN' 
}];
