import { Component, enableProdMode, OnInit, ViewChild } from '@angular/core';
import { DxDataGridComponent } from 'devextreme-angular';
import notify from 'devextreme/ui/notify';
import { environment } from 'src/environments/environment';

// if (!/localhost/.test(document.location.host)) {
//   enableProdMode();
// }

if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-input-dl3-puchamp',
  templateUrl: './input-dl3-puchamp.component.html',
  styleUrls: ['./input-dl3-puchamp.component.scss']
})
export class InputDl3PuchampComponent implements OnInit {
  AbnormGridVisible: boolean = true;
  PUGridVisible: boolean = false;
  NewGridVisible: boolean = false;

  items: any[] | undefined;
  productTypes: ProductType[];
  productsStore: any;
  backButtonOptions: any;
  refreshButtonOptions: any;
  selectBoxOptions: any;
  RadioOptions: any;
  selectBoxmenu: any;
  addButtonOptions: any;
  saveButtonOptions: any;
  printButtonOptions: any;
  settingsButtonOptions: any;
  dateupOptions: string[] = ['02-11-2021', '02-12-2021', '02-01-2022', '14-02-2022', '18-02-2022', '19-02-2022'];

  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  Delayoversea: ControlDelayOversea[];
  PUabnormalDT: PUabnormal[];
  PUnewDT: PUnewPU[];
  PUDT: PUnewPU[];
  selectedItemKeys: any[] = [];
  
  priorities: string[] = [];
  tasks: any;

  constructor() {
    this.productTypes = productTypes
    this.productsStore = products;
    this.Delayoversea = DelayOverseaGrid;
    this.PUabnormalDT = PUabmormalTypes
    this.PUnewDT = PUnewTypes;
    this.PUDT = PUnewTypes;
  }
  onExporting(e: any) {
    console.log('onExporting',e)
  }
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }
  ngOnInit(): void {
    // throw new Error('Method not implemented.');

  }
  ngAfterViewInit(){
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
      value: this.dateupOptions[0]
    
    };

    this.RadioOptions = {
      items: this.priorities,
      layout:"horizontal",
      value: this.priorities[0],
      onclick:(e: any)=> {
      console.log('RadioOptions111',e)
      }
    
    };

    this.priorities = [
      'Abnormal',
      'PU',
      'New'
    ];
  }

  onValueChanged( e: any) {
    console.log('RadioOptions222',e.value)
    if(e.value == 'Abnormal'){
      this.AbnormGridVisible = true;
      this.PUGridVisible = false;
      this.NewGridVisible = false;
    }
    else if(e.value == 'PU'){
      this.AbnormGridVisible = false;
      this.PUGridVisible = true;
      this.NewGridVisible = false;
    }
    else if(e.value == 'New'){
      this.AbnormGridVisible = false;
      this.PUGridVisible = false;
      this.NewGridVisible = true;
    }

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

export class ProductType {
  id!: number;

  text!: string;
}
export class Product {
  text: string | undefined;

  type: number | undefined;
}
const productTypes: ProductType[] = [{
  id: 1,
  text: 'All',
}, {
  id: 2,
  text: 'Video Players',
}, {
  id: 3,
  text: 'Televisions',
}, {
  id: 4,
  text: 'Monitors',
}, {
  id: 5,
  text: 'Projectors',
}];
const products: Product[] = [{
  text: 'HD Video Player',
  type: 2,
}, {
  text: 'SuperHD Video Player',
  type: 2,
}, {
  text: 'SuperLCD 42',
  type: 3,
}, {
  text: 'SuperLED 42',
  type: 3,
}, {
  text: 'SuperLED 50',
  type: 3,
}, {
  text: 'SuperLCD 55',
  type: 3,
}, {
  text: 'DesktopLCD 19',
  type: 4,
}, {
  text: 'DesktopLCD 21',
  type: 4,
}, {
  text: 'DesktopLED 21',
  type: 4,
}, {
  text: 'Projector Plus',
  type: 5,
}, {
  text: 'Projector PlusHD',
  type: 5,
}];
export class PUabnormal {
  ID!: number;
  req_no!: string;
  req_details_no!: string;
  pur_incharge!: string;
  Item_Des!: string;
  maker!: string;
  type!: string;
  pur_req_qty!: string;
  unit!: string;
  Ship_To!: string;
  Status!: string;
  date_pass_af_rec!: string;
  rec_date_pur_req!: string;
  req_delivery_date!: string;
  Action!: string;
  date_up!: string;
}
export class PUnewPU {
  ID!: number;
  req_no!: string;
  req_details_no!: string;
  pur_incharge!: string;
  Item_Des!: string;
  maker!: string;
  type!: string;
  pur_req_qty!: string;
  unit!: string;
  Ship_To!: string;
  Status!: string;
  date_pass_af_rec!: string;
  rec_date_pur_req!: string;
  req_delivery_date!: string;
  date_up!: string;
}
const PUabmormalTypes: PUabnormal[] = [{
  ID: 1,
  req_no: '151010091612' ,
  req_details_no: '20' ,
  pur_incharge: 'PHOOPHA MONTHAKARN PUR3 C.PRACHINBURI THAILA / PHOOPHA MONTHAKARN PUR3 C.PRACHINBURI THAILA' ,
  Item_Des: 'PLASTIC ESD RED (24x36)(Standard Pack=500 Pcs/Pack)' ,
  maker: 'No brand' ,
  type: 'Size : 24 x 36 x 0.03 MM (MOQ=6,500)' ,
  pur_req_qty: '6000' ,
  unit: 'PCS' ,
  Ship_To: 'CPT.PURCHASE FRONT DESK' ,
  Status: 'approved purchase request' ,
  date_pass_af_rec:'77',
  rec_date_pur_req: '10/22/2021' ,
  req_delivery_date: '3/1/2022' ,
  Action: '' ,
  date_up: '3/1/2022'
}, {
  ID: 2,
  req_no: '151010091611' ,
  req_details_no: '1' ,
  pur_incharge: 'PHOOPHA MONTHAKARN PUR3 C.PRACHINBURI THAILA / PHOOPHA MONTHAKARN PUR3 C.PRACHINBURI THAILA' ,
  Item_Des: 'PLASTIC ESD RED (24x36)(Standard Pack=500 Pcs/Pack)' ,
  maker: 'No brand' ,
  type: 'Size : 24 x 36 x 0.03 MM (MOQ=6,500)' ,
  pur_req_qty: '6000' ,
  unit: 'PCS' ,
  Ship_To: 'CPT.PURCHASE FRONT DESK' ,
  Status: 'approved purchase request' ,
  date_pass_af_rec:'77',
  rec_date_pur_req: '10/22/2021' ,
  req_delivery_date: '5/10/2022' ,
  Action: '' ,
  date_up: '3/1/2022'
}, {
  ID: 3,
  req_no: '151010092629' ,
  req_details_no: '4' ,
  pur_incharge: 'PRAKOPSUK KUNLATHIDA PUR3 C.PRACHINBURI THAILA / PRAKOPSUK KUNLATHIDA PUR3 C.PRACHINBURI THAILA' ,
  Item_Des: 'Pipe Flax' ,
  maker: 'No brand' ,
  type: '1.5' ,
  pur_req_qty: '100' ,
  unit: 'M' ,
  Ship_To: 'CPT.PURCHASE FRONT DESK' ,
  Status: 'approved purchase request' ,
  date_pass_af_rec:'50',
  rec_date_pur_req: '11/18/2021' ,
  req_delivery_date: '11/23/2021' ,
  Action: '' ,
  date_up: '3/1/2022'
}, {
  ID: 4,
  req_no: '151010093042' ,
  req_details_no: '1' ,
  pur_incharge: 'BURANAPAN MATHAWEE PUR3 C.PRACHINBURI THAILA / BURANAPAN MATHAWEE PUR3 C.PRACHINBURI THAILA' ,
  Item_Des: 'LED MONITOR LENOVO' ,
  maker: 'MATERIAL AUTOMATION (THAILAND) CO.,LTD.' ,
  type: 'Q27q-1L - 27 2560x1440 16:9 HDMI DP 3Y' ,
  pur_req_qty: '1' ,
  unit: 'PCS' ,
  Ship_To: 'CPT.PURCHASE FRONT DESK' ,
  Status: 'approved purchase request' ,
  date_pass_af_rec:'36',
  rec_date_pur_req: '12/2/2021' ,
  req_delivery_date: '12/17/2021' ,
  Action: '' ,
  date_up: '3/1/2022'
}];
const PUnewTypes: PUnewPU[] = [{
  ID: 1,
  req_no: '151010001417' ,
  req_details_no: '1' ,
  pur_incharge: 'KAEWSRI KANNIKA PURC C.PRACHINBURI THAILA / KAEWSRI KANNIKA PURC C.PRACHINBURI THAILA' ,
  Item_Des: 'PLASTIC ESD RED (24x36)(Standard Pack=500 Pcs/Pack)' ,
  maker: 'Tajima' ,
  type: '2090160' ,
  pur_req_qty: '20' ,
  unit: 'PCS' ,
  Ship_To: 'CPT.PURCHASE FRONT DESK' ,
  Status: 'under making PO' ,
  date_pass_af_rec: '3127' ,
  rec_date_pur_req: '6/26/2013' ,
  req_delivery_date: '7/5/2013' ,
  date_up: '3/1/2022'
}, {
  ID: 2,
  req_no: '151010000154' ,
  req_details_no: '1' ,
  pur_incharge: 'KAEWSRI KANNIKA PURC C.PRACHINBURI THAILA / KAEWSRI KANNIKA PURC C.PRACHINBURI THAILA' ,
  Item_Des: 'Sakura Identi-Pen XYK-T T-Twin Heade Permanent Marker' ,
  maker: 'Sakura' ,
  type: '1080043' ,
  pur_req_qty: '50' ,
  unit: 'PCS' ,
  Ship_To: 'CPT.PURCHASE FRONT DESK' ,
  Status: 'under making PO' ,
  date_pass_af_rec: '3127' ,
  rec_date_pur_req: '6/26/2013' ,
  req_delivery_date: '7/5/2013' ,
  date_up: '3/1/2022'
}, {
  ID: 3,
  req_no: '151010001597' ,
  req_details_no: '1' ,
  pur_incharge: 'SUKSOMJIT PANNEE PURC C.PRACHINBURI THAILA / SUKSOMJIT PANNEE PURC C.PRACHINBURI THAILA' ,
  Item_Des: 'Thermal Paper TP-S245L-1' ,
  maker: 'KTJ' ,
  type: 'Thermal Paper TP-S245L-1' ,
  pur_req_qty: '5' ,
  unit: 'BX' ,
  Ship_To: 'CPT.PURCHASE FRONT DESK' ,
  Status: 'under making PO' ,
  date_pass_af_rec: '3023' ,
  rec_date_pur_req: '10/8/2013' ,
  req_delivery_date: '10/31/2013' ,
  date_up: '3/1/2022'
}, {
  ID: 4,
  req_no: '151010001883' ,
  req_details_no: '1' ,
  pur_incharge: 'KHAMWONG PITCHAYAKON PUR3 C.PRACHINBURI THAILA / KHAMWONG PITCHAYAKON PUR3 C.PRACHINBURI THAILA' ,
  Item_Des: 'Panel Holder (T= 3mm) (GFA-803G)' ,
  maker: 'SUS' ,
  type: 'Panel Holder (T= 3mm) (GFA-803G)' ,
  pur_req_qty: '20' ,
  unit: 'PCS' ,
  Ship_To: 'CPT.PURCHASE FRONT DESK' ,
  Status: 'under making PO' ,
  date_pass_af_rec: '3006' ,
  rec_date_pur_req: '10/25/2013' ,
  req_delivery_date: '10/31/2013' ,
  date_up: '3/1/2022'
}];