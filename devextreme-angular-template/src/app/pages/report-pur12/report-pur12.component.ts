import { Component, OnInit, ViewChild } from '@angular/core';
import axios from 'axios';
import { DxFormComponent } from 'devextreme-angular';
// import { Employee, Service, dailyPur12 } from 'src/app/shared/services/api-service';
import notify from 'devextreme/ui/notify';
import { environment } from 'src/environments/environment';
import { ApiService } from 'src/app/shared/services/api.service';
import { Settings } from 'src/app/shared/services/setting';


@Component({
  selector: 'app-report-pur12',
  // providers: [Service],
  templateUrl: './report-pur12.component.html',
  styleUrls: ['./report-pur12.component.scss']
})
export class ReportPur12Component implements OnInit {
  @ViewChild(DxFormComponent, { static: false })
  myform!: DxFormComponent;
  @ViewChild("form_domestic") formpurup!: DxFormComponent;
  dataPur12:any; //dailyPur12;
  employee:any; //Employee;
  positions: string[];
  dwformatButtonOptions: any;
  refreshButtonOptions: any;
   title = 'ng-xlsx-example';
   employee33 = [
    { name: 'Shyam', email: 'shyamjaiswal@gmail.com' },
    { name: 'Bob', email: 'bob32@gmail.com' },
    { name: 'Jai', email: 'jai87@gmail.com' },
  ];
  yesterday: Date = new Date(new Date().setDate(new Date().getDate()-1)); 
  date: any = {
    domestic: this.yesterday,
    oversea: this.yesterday
  }

  isLoadPanelVisible: boolean = false;

  buttonOptions1 :any = {
    stylingMode: "contained",
    type: "success",
    icon: "download",
    useSubmitBehavior: "true",
    onClick: () => {
      this.isLoadPanelVisible = true;
      this.pull_domestic()
    },
  }

  buttonOptions2 :any = {
    stylingMode: "contained",
    type: "success",
    icon: "download",
    useSubmitBehavior: "true",
    onClick: () => {
      this.isLoadPanelVisible = true;
      this.pull_oversea()
    },
  }

  showMessage = () => {
    notify("The button was clicked");
  }  
  error: any = {};


  constructor( 
    public service: ApiService
    ) {
    this.employee = []//service.getEmployee();
    this.positions = []//service.getPositions();
    this.dataPur12 = []//service.getReportPUR12();

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

  async pull_domestic(){
    if(this.date.domestic != "" && this.date.domestic != undefined){ 
      try {
        await axios.post(`${environment.api}Domestic/EUC?dt=${this.service.convertdate(this.date.domestic)}`, null, Settings.headers)
        this.show_success();
      } 
      catch (error: any) {
        this.show_error(error)
      }
    }
  }

  async pull_oversea(){
    if(this.date.oversea != "" && this.date.oversea != undefined){ 
      try {
        await axios.post(`${environment.api}Oversea/EUC?dt=${this.service.convertdate(this.date.oversea)}`, null, Settings.headers)    
        this.show_success();  
      } 
      catch (error: any) {
        this.show_error(error)
      }
    }
  }

  onShown() {
    setTimeout(() => {
      this.isLoadPanelVisible = false;
    }, 1000);
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
