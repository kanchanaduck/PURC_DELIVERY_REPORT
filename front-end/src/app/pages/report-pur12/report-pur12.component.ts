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
  @ViewChild("form_domestic") formpurup!: DxFormComponent;
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

  date: any = {
    domestic: '05/09/2022',
    oversea: '05/09/2022'
  }

  loadingVisible = false;

  buttonOptions1 :any = {
    stylingMode: "contained",
    type: "success",
    icon: "download",
    useSubmitBehavior: "true",
    onClick: () => {
      this.pull_domestic()
    },
  }

  buttonOptions2 :any = {
    stylingMode: "contained",
    type: "success",
    icon: "download",
    useSubmitBehavior: "true",
    onClick: () => {
      this.pull_oversea()
    },
  }

  showMessage = () => {
    notify("The button was clicked");
  }  
  error: any = {};


  constructor( service: Service,
    public apiPUR: Service) {
    this.employee = service.getEmployee();
    this.positions = service.getPositions();
    this.dataPur12 = service.getReportPUR12();

    this.refreshButtonOptions = {
      icon: 'refresh',
      onClick: () => {
        notify('Refresh button has been clicked!');
      },
    };
  }

 /*  form_upload (e: any) {
      if(e.dataField == "domestic" && e.value != null){ this.domestic = this.convert(e.value);}
      else if(e.dataField == "oversea" && e.value != null){ this.oversea = this.convert(e.value);}
      else if(e.dataField == "oversea" && e.value == null){ this.oversea = ""; }
      else if(e.dataField == "domestic" && e.value == null){ this.domestic = ""; }

  } */
  convert(str: string | number | Date) {
    var date = new Date(str),
      mnth = ("0" + (date.getMonth() + 1)).slice(-2),
      day = ("0" + date.getDate()).slice(-2);
    return [date.getFullYear(), mnth, day].join("");
  }

  async pull_domestic(){
    if(this.date.domestic != "" && this.date.domestic != undefined){ 
      this.loadingVisible = true;
      console.log(this.loadingVisible)
      try {
        await this.apiPUR.sv_post_paramEUC("Domestic/gett_euc_domestic","?dt=" + this.convert(this.date.domestic))
        this.show_success();
      } 
      catch (error: any) {
        this.show_error(error)
      }
      this.loadingVisible = false;
    }
  }

  async pull_oversea(){
    if(this.date.oversea != "" && this.date.oversea != undefined){ 
      this.loadingVisible = true;
      console.log(this.loadingVisible)
      try {
        await this.apiPUR.sv_post_paramEUC("Oversea/gett_euc_oversea","?dt=" + this.convert(this.date.oversea))    
        this.show_success();  
      } 
      catch (error: any) {
        this.show_error(error)
      }
      this.loadingVisible = false;
    }
  }

  show_success(){
    notify("Complete!", "success");
  }

  show_error(error: any){
    var text = typeof error.response.data === 'object'? error.response.data.title:error.response.data
    notify("Error! "+text, "error");
  }

  ngOnInit(): void {

  }

  ngAfterViewInit() {
    // this.myform.instance.validate();
  }
}
