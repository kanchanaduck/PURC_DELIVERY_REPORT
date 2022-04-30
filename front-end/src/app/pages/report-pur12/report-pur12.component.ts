import { Component, enableProdMode, NgModule, OnInit, ViewChild } from '@angular/core';
import { DxFormComponent} from 'devextreme-angular';
import { Employee, Service, dailyPur12 } from 'src/app/shared/services/api-service';
import notify from 'devextreme/ui/notify';
import { environment } from 'src/environments/environment';

const EXCEL_TYPE =
  'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8';

  if (environment.production) {
    enableProdMode();
  }

@Component({
  selector: 'app-report-pur12',
  providers: [Service],
  templateUrl: './report-pur12.component.html',
  styleUrls: ['./report-pur12.component.scss']
})
export class ReportPur12Component implements OnInit {
  @ViewChild(DxFormComponent, { static: false })
  myform!: DxFormComponent;
  @ViewChild("formupload") formpurup!: DxFormComponent;
  dataPur12: dailyPur12;
  employee: Employee;
  positions: string[];
  dwformatButtonOptions: any;
  refreshButtonOptions: any;
   title = 'ng-xlsx-example';
   employee33 = [
    { name: 'Shyam', email: 'shyamjaiswal@gmail.com' },
    { name: 'Bob', email: 'bob32@gmail.com' },
    { name: 'Jai', email: 'jai87@gmail.com' },
  ];
  dt_domestic!: string;
  dt_oversea!: string;
  loadingVisible = false;

  showMessage = () => {
    notify("The button was clicked");
}
  /*name of the excel-file which will be downloaded. */ 
fileName= 'ExcelSheet.xlsx';  
exportexcel= () => {
      const link = document.createElement('a');
      link.setAttribute('target', '_blank');
      link.setAttribute('href', 'assets/format_PUR1_2/format pur.xlsx');
      link.setAttribute('download', `format pur.xlsx`);
      document.body.appendChild(link);
      link.click();
      link.remove();

    // const worksheet: XLSX.WorkSheet = XLSX.utils.json_to_sheet(this.employee33);
    // const workbook: XLSX.WorkBook = {
    //   Sheets: { Sheet1: worksheet },
    //   SheetNames: ['Sheet1'],
    // };

    // const excelBuffer: any = XLSX.write(workbook, {
    //   bookType: 'xlsx',
    //   type: 'array',
    // });

    // const data: Blob = new Blob([excelBuffer], { type: EXCEL_TYPE });
    // const date = new Date();
    // const fileName = 'example.xlsx';

    // FileSaver.saveAs(data, fileName);
			
    }


  constructor( service: Service,
    public apiPUR: Service) {
    this.employee = service.getEmployee();
    this.positions = service.getPositions();
    this.dataPur12 = service.getReportPUR12();
    
    this.dwformatButtonOptions = {
      icon: 'download',
      text: 'Download',
      onClick: () => {
        this.showMessage();
        this.exportexcel();
      },
    };

    this.refreshButtonOptions = {
      icon: 'refresh',
      onClick: () => {
        notify('Refresh button has been clicked!');
      },
    };
  }

  form_upload (e: any) {
      if(e.dataField == "domestic" && e.value != null){ this.dt_domestic = this.convert(e.value);}
      else if(e.dataField == "oversea" && e.value != null){ this.dt_oversea = this.convert(e.value);}
      else if(e.dataField == "oversea" && e.value == null){ this.dt_oversea = ""; }
      else if(e.dataField == "domestic" && e.value == null){ this.dt_domestic = ""; }

  }
  convert(str: string | number | Date) {
    var date = new Date(str),
      mnth = ("0" + (date.getMonth() + 1)).slice(-2),
      day = ("0" + date.getDate()).slice(-2);
    return [date.getFullYear(), mnth, day].join("");
    }
  async BtnNewClick(e: any){

    if(this.dt_domestic != "" && this.dt_domestic != undefined){ 
      this.loadingVisible = true;
      await this.apiPUR.sv_post_paramEUC("input_domestic/gett_euc_domestic","?dt=" + this.dt_domestic)
    }
    if(this.dt_oversea != "" && this.dt_oversea != undefined){ 
      this.loadingVisible = true;
      await this.apiPUR.sv_post_paramEUC("input_Oversea/gett_euc_oversea","?dt=" + this.dt_oversea)
    }
  
  }
  onShown() {
    setTimeout(() => {
      this.loadingVisible = false;
    }, 3000);
  }

  onHidden() {
    notify("Complete!");
  }

  ngOnInit(): void {

  }
  ngAfterViewInit() {
    this.myform.instance.validate();
  }
}
