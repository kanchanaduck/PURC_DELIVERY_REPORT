import { Component, enableProdMode, NgModule, OnInit } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { DxCheckBoxModule, DxDataGridModule } from 'devextreme-angular';
import notify from 'devextreme/ui/notify';
import { AppComponent } from 'src/app/app.component';
import { environment } from 'src/environments/environment';

// if (!/localhost/.test(document.location.host)) {
//   enableProdMode();
// }
if (environment.production) {
  enableProdMode();
}
@Component({
  selector: 'app-input-reason',
  templateUrl: './input-reason.component.html',
  styleUrls: ['./input-reason.component.scss']
})
export class InputReasonComponent implements OnInit {
  customers: Customer[];
  dateupOptions: string[] = ['02-11-2021', '02-12-2021', '02-01-2022', '14-02-2022', '18-02-2022', '19-02-2022'];
  selectBoxOptions: any;
  refreshButtonOptions: any;

  constructor() {
  this.customers = сustomersgrid;
  
  this.refreshButtonOptions = {
    icon: 'refresh',
    onClick: () => {
      notify('Refresh button has been clicked!');
    },
  };
  this.selectBoxOptions = {
    width: 160,
    items: this.dateupOptions,
    // valueExpr: 'id',
    // displayExpr: 'text',
    value: this.dateupOptions[0],
    onValueChanged: (args: { value: number; }) => {
   
    },
  };
  }
  onCellPrepared (e: any) {
    console.log('onCellPrepared',e);
    if (e.rowType == "detailAdaptive") {
        e.cellElement.addClass("adaptiveRowStyle");
    }
}

cellSt_CheckStyles(text: any){
  var classList = '';
  if(text == 'Completed'){
    classList = 'stcomplete'; 
  }else if(text == 'Over Lead time'){
    classList = 'stovertime';
  }
  else{
    classList = 'stwait';
  }
  return classList;
  }

  ngOnInit(): void {
  }

}

export class Customer {
  ID!: number;
  subject!: string;
  ct_Domestic!: string;
  class_ct_Domestic!: string;
  ct_oversae!: string;
  po_issued!: string;
  dl_Domestic!: string;
  dl_oversae!: string;
  pu_champ!: string;
  ct_evalio!: string;
  shot_lt!: string;
}

const сustomersgrid: Customer[] = [{
  ID: 1,
  subject: 'Report Daily 01-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'adaptiveRowStyle',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Wait Buyer Input',
  ct_evalio: 'Over Lead time',
  shot_lt: 'Wait PURC Check'
}, {
  ID: 2,
  subject: 'Report Daily 02-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'adaptiveRowStyle',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Over Lead time'
}, {
  ID: 3,
  subject: 'Report Daily 03-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 4,
  subject: 'Report Daily 04-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 5,
  subject: 'Report Daily 05-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 6,
  subject: 'Report Daily 06-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 7,
  subject: 'Report Daily 07-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 8,
  subject: 'Report Daily 08-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 9,
  subject: 'Report Daily 09-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 10,
  subject: 'Report Daily 10-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 11,
  subject: 'Report Daily 11-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 12,
  subject: 'Report Daily 12-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 13,
  subject: 'Report Daily 13-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 14,
  subject: 'Report Daily 14-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 15,
  subject: 'Report Daily 15-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 16,
  subject: 'Report Daily 16-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 17,
  subject: 'Report Daily 17-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 18,
  subject: 'Report Daily 18-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 19,
  subject: 'Report Daily 19-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}, {
  ID: 20,
  subject: 'Report Daily 20-Jan-2022',
  ct_Domestic: 'Completed',
  class_ct_Domestic:'',
  ct_oversae: 'Completed',
  po_issued: 'Completed',
  dl_Domestic: 'Completed',
  dl_oversae: 'Completed',
  pu_champ: 'Completed',
  ct_evalio: 'Completed',
  shot_lt: 'Completed'
}];

@NgModule({
  imports: [
    BrowserModule,
    DxDataGridModule,
    DxCheckBoxModule,
  ],
  bootstrap: [AppComponent],
})
export class AppModule { }

platformBrowserDynamic().bootstrapModule(AppModule);