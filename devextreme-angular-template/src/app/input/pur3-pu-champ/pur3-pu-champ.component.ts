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
  selector: 'app-pur3-pu-champ',
  templateUrl: './pur3-pu-champ.component.html',
  styleUrls: ['./pur3-pu-champ.component.scss']
})
export class Pur3PuChampComponent implements OnInit {
  AbnormGridVisible: boolean = true;
  PUGridVisible: boolean = false;
  NewGridVisible: boolean = false;

  items: any[] | undefined;
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
  PUabnormalDT: any;
  PUnewDT: any;
  PUDT: any;
  selectedItemKeys: any[] = [];
  
  priorities: string[] = [];
  tasks: any;
  productTypes: any;
  Delayoversea: any;

  constructor() {
    this.productTypes = []
    this.productsStore = []
    this.Delayoversea = []
    this.PUabnormalDT = [] 
    this.PUnewDT = []
    this.PUDT = []
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