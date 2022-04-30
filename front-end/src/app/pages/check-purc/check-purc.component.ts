import { Component, enableProdMode, OnInit } from '@angular/core';
import notify from 'devextreme/ui/notify';
import { DomesticGridPUR12, EmployeePur12, Service } from 'src/app/shared/services/api-service';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}
@Component({
  selector: 'app-check-purc',
  templateUrl: './check-purc.component.html',
  providers: [Service],
  styleUrls: ['./check-purc.component.scss']
})
export class CheckPurcComponent implements OnInit {

  refreshButtonOptions: any;
  employee: EmployeePur12;
  positions: string[];
  rules: Object;
  dataSource:DomesticGridPUR12[];
  selectedItemKeys: any[] = [];
  Arr_TSSResult: string[] = ['Effected','No Effected']
  status_Result: string[] = ['OK','NG']
  constructor(service: Service) {
    this.employee = service.getEmployeePur12();
    this.positions = service.getPositions12pur();
    this.rules = { X: /[02-9]/ };
    this.dataSource = service.getDomesticGrid12();
    
    this.refreshButtonOptions = {
      icon: 'refresh',
      onClick: () => {
        notify('Refresh button has been clicked!');
      },
    };
   }
   selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
  }
  //  ngAfterViewInit() {
  //   this.myform.instance.validate();
  // }

  onExporting(e: any) {
    console.log('onExporting',e)
  
  }
  ngOnInit(): void {
  }


}
