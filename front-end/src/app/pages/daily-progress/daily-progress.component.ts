import { Component, enableProdMode, OnInit } from '@angular/core';
import notify from 'devextreme/ui/notify';
import { environment } from 'src/environments/environment';

// if (!/localhost/.test(document.location.host)) {
//   enableProdMode();
// }

if (environment.production) {
  enableProdMode();
}
@Component({
  selector: 'app-daily-progress',
  templateUrl: './daily-progress.component.html',
  styleUrls: ['./daily-progress.component.scss']
})
export class DailyProgressComponent implements OnInit {
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
  customizeColumns (cellInfo: any) {
    console.log('customizeColumns',cellInfo);
    return cellInfo.value + "$";
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
  system_download!: string;
  Buyer_input!: string;
  Leader_check!: string;
  Manager_check!: string;
  other_dept_check!: string;
  purc_check!: string;
}

const сustomersgrid: Customer[] = [{
  ID: 1,
  subject: 'Report Daily 01-Jan-2022',
  system_download: 'Completed',
  Buyer_input:'Completed',
  Leader_check: 'Completed',
  Manager_check: 'Wait Mgr. check',
  other_dept_check: '',
  purc_check: ''
}, {
  ID: 2,
  subject: 'Report Daily 02-Jan-2022',
  system_download: 'Completed',
  Buyer_input:'Completed',
  Leader_check: 'Completed',
  Manager_check: 'Completed',
  other_dept_check: 'Over Lead time',
  purc_check: ''
}, {
  ID: 3,
  subject: 'Report Daily 03-Jan-2022',
  system_download: 'Completed',
  Buyer_input:'Completed',
  Leader_check: 'Completed',
  Manager_check: 'Completed',
  other_dept_check: 'Completed',
  purc_check: 'Completed'
}, {
  ID: 4,
  subject: 'Report Daily 04-Jan-2022',
  system_download: 'Completed',
  Buyer_input:'Completed',
  Leader_check: 'Completed',
  Manager_check: 'Completed',
  other_dept_check: 'Completed',
  purc_check: 'Completed'
}];
