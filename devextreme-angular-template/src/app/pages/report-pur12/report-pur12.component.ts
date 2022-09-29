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

  domestic_date: any = {
    date_start: this.yesterday,
    date_end: this.yesterday,
  }

  oversea_date: any = {
    date_start: this.yesterday,
    date_end: this.yesterday
  }

  isLoadPanelVisible: boolean = false;

  buttonOptions1 :any = {
    stylingMode: "contained",
    text: "pull",
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
    text: "pull",
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
  }

  async pull_domestic(){
    for (var d = new Date(this.domestic_date.date_start); d <= new Date(this.domestic_date.date_end); d.setDate(d.getDate() + 1)) {
      try {
        let message = await axios.post(`${environment.api}Domestic/EUC?dt=${this.service.convertdate(new Date(d))}`, null, Settings.headers)    
        console.log(message)
        this.show_success(message.data);  
      } 
      catch (error: any) {
        this.show_error(error)
      }
    }
  }

  async pull_oversea(){
    for (var d = new Date(this.oversea_date.date_start); d <= new Date(this.oversea_date.date_end); d.setDate(d.getDate() + 1)) {
      try {
        let message = await axios.post(`${environment.api}Oversea/EUC?dt=${this.service.convertdate(new Date(d))}`, null, Settings.headers)    
        console.log(message)
        this.show_success(message.data);  
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

  show_success(message){
    notify({
      message: message, 
      height: 60,
      width: 300,
      minWidth: 150,
      type: "success", 
      animation: {
        show: {
          type: 'fade', duration: 400, from: 0, to: 1,
        },
        hide: { type: 'fade', duration: 40, to: 0 },
      },
    },
      {
        position: 'bottom center',
        direction: 'up-push'
      });
  }

  show_error(error: any){
    var text = typeof error.response.data === 'object'? error.response.data.title:error.response.data
    notify({
      message: text, 
      height: 60,
      width: 300,
      minWidth: 150,
      type: "error", 
      animation: {
        show: {
          type: 'fade', duration: 400, from: 0, to: 1,
        },
        hide: { type: 'fade', duration: 40, to: 0 },
      },
    },
    {
      position: 'bottom center',
      direction: 'up-push'
    });

  }

  ngOnInit(): void {

  }

  ngAfterViewInit() {
    // this.myform.instance.validate();
  }
}
