import { Component, enableProdMode, OnInit } from '@angular/core';
import notify from 'devextreme/ui/notify';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-input-dl3-evalio',
  templateUrl: './input-dl3-evalio.component.html',
  styleUrls: ['./input-dl3-evalio.component.scss']
})
export class InputDl3EvalioComponent implements OnInit {
  evolioDT: ControlEvolio[];
  selectedItemKeys: any[] = [];
  dateupOptions: string[] = ['02-11-2021', '02-12-2021', '02-01-2022', '14-02-2022', '18-02-2022', '19-02-2022'];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  season_response: string[]  = ['D1 : 【Supplier】 Delivery ontime but invoice mistake.',
   'D2 : 【Supplier】 No delivery.',
   'D3 : 【Supplier】 Goods NG ',
   'D4 : 【Supplier】 No stock.',
   'D5 : 【Supplier】 Other.  (Please input the reason)',
   'D6 : 【CPT】 Waiting receive.',
   'D7 : 【CPT】 Other.  (Please input the reason)'];

  constructor() { 
    this.evolioDT = ControlEvolioGrid;
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
  onCellPrepared(e: any) {
    console.log('this.onCellPrepared : ', e)
    if(e.rowType === "data") {
        e.cellElement.style.color = e.data.Delay.indexOf("-", 0) == 0 ? "red" : "black";
      }
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
export class ControlEvolio {
  ID!: number;
  PR_No!: string;
  PO_No!: string;
  IssueDate!: string;
  Delivery_Date!: string;
  Today_Date!: string;
  Delay!: string;
  LT!: string;
  Resp_supp_cpt!: string;
  Remark_reason!: string;
  No!: string;
  Item!: string;
  Item_Name!: string;
  Quantity!: string;
  Remain!: string;
  Unit!: string;
  Unit_Price!: string;
  Currency!: string;
  Vendor_Code!: string;
  Vendor_Name!: string;
  Prepareby!: string;
  Center_Code!: string;
  Center_Name!: string;
  Expense_Code!: string;
  Equip_Budget_Code!: string;
}

const ControlEvolioGrid: ControlEvolio[] = [{
  ID: 1 ,
  PR_No: 'PGA-02690' ,
  PO_No: 'CPT-2021-00068' ,
  IssueDate: '12/22/2021' ,
  Delivery_Date: '1/31/2022' ,
  Today_Date: '1/17/2022  8:20:51 AM' ,
  Delay: '14' ,
  LT: '-40' ,
  Resp_supp_cpt: '' ,
  Remark_reason: '' ,
  No: '1' ,
  Item: '-' ,
  Item_Name: 'Drinking Water Limpid' ,
  Quantity: '5670' ,
  Remain: '2430' ,
  Unit: 'Pcs' ,
  Unit_Price: '23' ,
  Currency: '' ,
  Vendor_Code: 'X-141' ,
  Vendor_Name: 'POODECH DRINKING WATER LIMITED PARTNERSHIP' ,
  Prepareby: 'Ms. JARIYA YOTCOMLUE' ,
  Center_Code: '2110' ,
  Center_Name: 'Personnel & General Affairs Dept 1' ,
  Expense_Code: '' ,
  Equip_Budget_Code: '' 
}, {
  ID: 4,
  PR_No: 'PGA-02691' ,
  PO_No: 'CPT-2021-00069' ,
  IssueDate: '12/22/2021' ,
  Delivery_Date: '1/31/2022' ,
  Today_Date: '1/17/2022  8:20:51 AM' ,
  Delay: '-14' ,
  LT: '-40' ,
  Resp_supp_cpt: '' ,
  Remark_reason: '' ,
  No: '1' ,
  Item: '-' ,
  Item_Name: 'Drinking Water Limpid' ,
  Quantity: '5670' ,
  Remain: '2430' ,
  Unit: 'Pcs' ,
  Unit_Price: '23' ,
  Currency: '' ,
  Vendor_Code: 'X-141' ,
  Vendor_Name: 'POODECH DRINKING WATER LIMITED PARTNERSHIP' ,
  Prepareby: 'Ms. JARIYA YOTCOMLUE' ,
  Center_Code: '2110' ,
  Center_Name: 'Personnel & General Affairs Dept 1' ,
  Expense_Code: '' ,
  Equip_Budget_Code: '' 
}, {
  ID: 5,
  PR_No: 'PGA-02694' ,
  PO_No: 'CPT-2022-00001' ,
  IssueDate: '12/22/2021' ,
  Delivery_Date: '1/31/2022' ,
  Today_Date: '1/17/2022  8:20:51 AM' ,
  Delay: '14' ,
  LT: '-40' ,
  Resp_supp_cpt: '' ,
  Remark_reason: '' ,
  No: '1' ,
  Item: '-' ,
  Item_Name: 'Drinking Water Limpid' ,
  Quantity: '5670' ,
  Remain: '2430' ,
  Unit: 'Pcs' ,
  Unit_Price: '23' ,
  Currency: '' ,
  Vendor_Code: 'X-141' ,
  Vendor_Name: 'POODECH DRINKING WATER LIMITED PARTNERSHIP' ,
  Prepareby: 'Ms. JARIYA YOTCOMLUE' ,
  Center_Code: '2110' ,
  Center_Name: 'Personnel & General Affairs Dept 1' ,
  Expense_Code: '' ,
  Equip_Budget_Code: '' 
}];
