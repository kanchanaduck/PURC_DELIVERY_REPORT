import { HttpClient } from '@angular/common/http';
import { Component, OnInit, ViewChild } from '@angular/core';
import axios from 'axios';
import { DxDataGridComponent, DxFormComponent, 
         } from 'devextreme-angular';
import CustomStore from 'devextreme/data/custom_store';
import notify from 'devextreme/ui/notify';
import { ApiService } from 'src/app/shared/services/api.service';
import { Settings } from 'src/app/shared/services/setting';
import { environment } from 'src/environments/environment';
@Component({
  selector: 'app-pur12',
  templateUrl: './pur12.component.html',
  styleUrls: ['./pur12.component.scss']
})
export class Pur12Component{
  
  @ViewChild("reasonFormDomestic") reasonFormDomestic!: DxFormComponent;
  @ViewChild('targetDataGridDomestic', { static: false }) dataGridDomestic: DxDataGridComponent;
  
  @ViewChild("reasonFormOversea") reasonFormOversea!: DxFormComponent;
  @ViewChild('targetDataGridOversea', { static: false }) dataGridOversea: DxDataGridComponent;

  buyers: any;
  suppliers: any;
  
  reason_domestic_early: any;
  reason_domestic_delay: any;
  reason_domestic_shortlt: any;
  reason_oversea_early: any;
  reason_oversea_delay: any;
  reason_oversea_shortlt: any;

  tss_result: any = ["Effect", "No effect"];
  checked_result: string[] = ['OK','NG',''];

  dataSourceDomestic: any = [];
  dataSourceOversea: any = [];

  selectedItemKeys: any[] = [];
  
  popupDomesticVisible: boolean  = false;
  popupOverseaVisible: boolean  = false;

  searchDomesticButtonOptions:any = {};
  searchOverseaButtonOptions:any = {};

  submitButtonDomesticOptions:any = {};
  closeButtonDomesticOptions:any = {};
  
  submitButtonOverseaOptions:any = {};
  closeButtonOverseaOptions:any = {};

  startEditAction = 'click';

  showMoreDomestic: boolean=false;
  showMoreOversea: boolean=false;

  selectTextOnEditStart = true;

  yesterday: Date = new Date(new Date().setDate(new Date().getDate()-1)); 

  reasonDomesticData: any = {};
  reasonOverseaData: any = {};
  
  SearchPanelDomestic: any = {
    date_start: this.yesterday,
    date_end: this.yesterday
  }

  SearchPanelOversea: any = {
    date_start: this.yesterday,
    date_end: this.yesterday
  }

  conditionDomestic: any = ["ShortLT", "Delay", "OnTime", "Early","OverMonth", "IVTerm"]
  conditionOversea: any = ["ShortLT", "Delay", "OnTime", "Early", "OverMonth"]
  
  gotoButton: any = [
    { text: "Buyer", goto: "tss_result" },
    { text: "Other", goto: "other_result" },
    { text: "Leader", goto: "leader_result" },
    { text: "Manager", goto: "manager_result" },
    { text: "PURC", goto: "purc_result" }
  ];


  countRowsDomestic: number;
  countRowsOversea: number;
  
  countRowsDomesticChecked: number;
  countRowsOverseaChecked: number;

  popupCheckDomesticVisible: boolean = false;
  popupCheckOverseaVisible: boolean = false;
  
  checked: any;

  okCheckButtonDomestic: any;
  ngCheckButtonDomestic: any;
  unCheckButtonDomestic: any;
  closeCheckButtonDomestic: any;

  okCheckButtonOversea: any;
  ngCheckButtonOversea: any;
  unCheckButtonOversea: any;
  closeCheckButtonOversea: any;
  
  domestic_who_check: string;
  oversea_who_check: string;

  is_buyer: boolean = false;
  is_purc: boolean = false;
  is_manager: boolean = false;
  is_leader: boolean = false;
  is_other: boolean = false;

  constructor(public service: ApiService, private http: HttpClient ) {

    this.is_buyer = this.service.is_buyer();
    this.is_purc = this.service.is_purc();
    this.is_manager = this.service.is_manager();
    this.is_leader = this.service.is_leader();
    this.is_other = this.service.is_other();

    this.checked = [
      { 
        role: "Other", 
        visible: this.is_other
      },
      {
        role: "Leader", 
        visible: this.is_leader
      },
      {
        role: "Manager", 
        visible: this.is_manager
      },
      {
        role: "PURC",
        visible: this.is_purc
      }
    ]

    this.get_domestic()
    this.get_oversea()

    this.reason_domestic_shortlt = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Reason/PUR12/Domestic/ShortLT`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });

    this.reason_domestic_delay = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Reason/PUR12/Domestic/Delay`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });

    
    this.reason_domestic_early = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Reason/PUR12/Domestic/Early`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });

    this.reason_oversea_shortlt = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Reason/PUR12/Oversea/ShortLT`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });

    this.reason_oversea_delay = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Reason/PUR12/Oversea/Delay`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });

    
    this.reason_oversea_early = new CustomStore({
      key: 'ID',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get(`${environment.api}Reason/PUR12/Oversea/Early`, Settings.headers)
              .toPromise()
              .catch(() => { throw 'Data loading error' });
      }
    });

    this.buyers = new CustomStore({
      key: 'id',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get( `${environment.api}Person/Buyer`, Settings.headers)
              .toPromise()
              .then(result => {
                  // You can process the response here
                  return result;
              })
              .catch(() => { throw 'Data loading error' });
      }
    });

    
    this.suppliers = new CustomStore({
      key: 'id',
      loadMode: 'raw', // omit in the DataGrid, TreeList, PivotGrid, and Scheduler
      load: () => {
          return this.http.get( `${environment.api}Person/Supplier`, Settings.headers)
              .toPromise()
              .then(result => {
                  // You can process the response here
                  return result;
              })
              .catch(() => { throw 'Data loading error' });
      }
    });


    let that = this

    this.searchDomesticButtonOptions= {
      icon: "search",
      text: "Search",
      type: "success",
      onClick:async (e:any)=>{
        that.get_domestic()
      }
    };
  
    this.submitButtonDomesticOptions= {
      text: 'Submit',
      type: "success",
      onClick(e:any) {
        that.submit_domestic_reason(e);
        that.reasonFormDomestic.instance.resetValues();
        that.popupDomesticVisible = false;
      },
    };
  
    this.closeButtonDomesticOptions= {
      text: 'Close',
      onClick(e: any) {       
        that.reasonFormDomestic.instance.resetValues();
        that.popupDomesticVisible = false;
      },
    };

    this.okCheckButtonDomestic = {
      text: 'OK',
      type: "success",
      onClick(e:any) {
        that.okDomesticChecked(e)
        that.popupCheckDomesticVisible=false;
      },
    };

    this.ngCheckButtonDomestic = {
      text: 'NG',
      type: "danger",
      onClick(e:any) {
        that.ngDomesticChecked(e)
        that.popupCheckDomesticVisible=false;
      },
    };

    this.unCheckButtonDomestic = {
      text: 'Unchecked',
      type: "warning",
      onClick(e:any) {
        that.unDomesticChecked(e)
        that.popupCheckDomesticVisible=false;
      },
    };
   
    this.closeCheckButtonDomestic = {
      text: 'Close',
      onClick(e: any) { 
        that.popupCheckDomesticVisible=false;
      },
    };

    this.searchOverseaButtonOptions= {
      icon: "search",
      text: "Search",
      type: "success",
      onClick:async (e:any)=>{
        that.get_oversea()
      }
    };
  
    this.submitButtonOverseaOptions= {
      text: 'Submit',
      type: "success",
      onClick(e:any) {
        that.submit_oversea_reason(e);
        that.reasonFormOversea.instance.resetValues();
        that.popupOverseaVisible = false;
      },
    };
  
    this.closeButtonOverseaOptions= {
      text: 'Close',
      onClick(e: any) {       
        that.reasonFormOversea.instance.resetValues();
        that.popupOverseaVisible = false;
      },
    };

    this.okCheckButtonOversea = {
      text: 'OK',
      type: "success",
      onClick(e:any) {
        that.okOverseaChecked(e)
        that.popupCheckOverseaVisible=false;
      },
    };

    this.ngCheckButtonOversea = {
      text: 'NG',
      type: "danger",
      onClick(e:any) {
        that.ngOverseaChecked(e)
        that.popupCheckOverseaVisible=false;
      },
    };
   
    this.unCheckButtonOversea = {
      text: 'Unchecked',
      type: "warning",
      onClick(e:any) {
        that.unOverseaChecked(e)
        that.popupCheckOverseaVisible=false;
      },
    };

    this.closeCheckButtonOversea = {
      text: 'Close',
      onClick(e: any) { 
        that.popupCheckOverseaVisible=false;
      },
    };
  }


  async get_domestic(){

    // console.log(this.SearchPanelDomestic)
    let search = this.SearchPanelDomestic;

    let date_start = this.service.convertdate(search.date_start)
    let date_end =  this.service.convertdate(search.date_end)
    let buyer = search.buyer? search.buyer:null
    let supplier = search.supplier? search.supplier:null

    let loadUrl = `Domestic?date_start=${date_start}&date_end=${date_end}`
    loadUrl += search.buyer === undefined || search.buyer === null ? ``:`&buyer=${buyer}`
    loadUrl += search.supplier === undefined || search.supplier === null ? ``:`&supplier=${supplier}`

    search.Delay? loadUrl += `&Delay=true` : ``
    search.Early? loadUrl += `&Early=true` : ``
    search.IVTerm? loadUrl += `&IVTerm=true` : ``
    search.OnTime? loadUrl += `&OnTime=true` : ``
    search.ShortLT? loadUrl += `&ShortLT=true` : ``
    search.OverMonth? loadUrl += `&OverMonth=true` : ``

    // console.log(loadUrl)

    this.dataSourceDomestic = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(loadUrl),
      update: (key, values) => this.service.sendRequest(`Domestic/Update/${key}`, 'PUT', values),
    });

   this.countRowsDomestic =  await this.dataGridDomestic.instance.totalCount()

  }

  go_to_domestic(what: any) {
    let scrollInstance = this.dataGridDomestic.instance.getScrollable();
    let cellElement = this.dataGridDomestic.instance.getCellElement(0, what.itemData.goto);
    scrollInstance.scrollToElement(cellElement); 
  }

  
  go_to_oversea(what: any) {
    let scrollInstance = this.dataGridOversea.instance.getScrollable();
    let cellElement = this.dataGridOversea.instance.getCellElement(0, what.itemData.goto);
    scrollInstance.scrollToElement(cellElement); 
  }

  async get_oversea(){

    // console.log(this.SearchPanelOversea)
    let search = this.SearchPanelOversea

    let date_start = this.service.convertdate(search.date_start)
    let date_end =  this.service.convertdate(search.date_end)
    let buyer = search.buyer? search.buyer:null
    let supplier = search.supplier? search.supplier:null

    let loadUrl = `Oversea?date_start=${date_start}&date_end=${date_end}`
    loadUrl += search.buyer === undefined || search.buyer === null ? ``:`&buyer=${buyer}`
    loadUrl += search.supplier === undefined || search.supplier === null ? ``:`&supplier=${supplier}`

    search.Delay? loadUrl += `&Delay=true` : ``
    search.Early? loadUrl += `&Early=true` : ``
    search.IVTerm? loadUrl += `&IVTerm=true` : ``
    search.OnTime? loadUrl += `&OnTime=true` : ``
    search.ShortLT? loadUrl += `&ShortLT=true` : ``
    search.OverMonth? loadUrl += `&OverMonth=true` : ``

    // console.log(loadUrl)

    this.dataSourceOversea = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(loadUrl),
      update: (key, values) => this.service.sendRequest(`Oversea/Update/${key}`, 'PUT', values),
    });

    this.countRowsOversea =  await this.dataGridOversea.instance.totalCount()

  }

  showInfoDomestic(e: any, who:string) {

    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(c));

    if(!(data.length > 0)){
      notify("Warning! please select item", "warning")
      return ;
    }

    if(who===undefined){
      this.popupDomesticVisible = true;
    }
    else{
      this.countRowsDomesticChecked = data.length;
      this.domestic_who_check = who;
      this.popupCheckDomesticVisible = true;
    }
  }

  showInfoOversea(e: any, who:string) {

    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(c));

    if(!(data.length > 0)){
      notify("Warning! please select item", "warning")
      return ;
    }

    if(who===undefined){
      this.popupOverseaVisible = true;
    }
    else{
      this.countRowsOverseaChecked = data.length;
      this.oversea_who_check = who;
      this.popupCheckOverseaVisible = true;
    }
  }
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys; 
  }

  onExporting(e: any) {
    console.log('onExporting',e)
  }

  async submit_domestic_reason(e:any){
    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(
      {
        ID: c,
        ...this.reasonDomesticData
      })
    );
    console.log("this.reasonDomesticData",this.reasonDomesticData)
    console.log("data",data)
    try {
      await axios.post(`${environment.api}Domestic/InputReasonMultiple`, data, Settings.headers)
      this.service.show_success()
      this.get_domestic()
    } 
    catch (error) {
      this.service.show_error(error)
    }
  }

  async okDomesticChecked(e:any){
    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(
      {
        ID: c
      })
    );
    try {
      await axios.post(`${environment.api}Domestic/${this.domestic_who_check}Checked?result=OK`, data, Settings.headers)
      this.service.show_success()
      this.get_domestic()
    } 
    catch (error) {
      this.service.show_error(error)
    }
  }

  async ngDomesticChecked(e:any){
    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(
      {
        ID: c
      })
    );
    try {
      await axios.post(`${environment.api}Domestic/${this.domestic_who_check}Checked?result=NG`, data, Settings.headers)
      this.service.show_success()
      this.get_domestic()
    } 
    catch (error) {
      this.service.show_error(error)
    }
  }

  
  async unDomesticChecked(e:any){
    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(
      {
        ID: c
      })
    );
    try {
      await axios.post(`${environment.api}Domestic/${this.domestic_who_check}Checked?result`, data, Settings.headers)
      this.service.show_success()
      this.get_domestic()
    } 
    catch (error) {
      this.service.show_error(error)
    }
  }

  async submit_oversea_reason(e:any){
    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(
      {
        ID: c,
        ...this.reasonOverseaData
      })
    );
    // reasonFormOversea
    console.log(this.reasonOverseaData)
    console.log(data)
    try {
      await axios.post(`${environment.api}Oversea/InputReasonMultiple`, data, Settings.headers)
      this.service.show_success()
      this.get_oversea()
    } 
    catch (error) {
      this.service.show_error(error)
    }
  }

  async okOverseaChecked(e:any){
    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(
      {
        ID: c
      })
    );
    try {
      await axios.post(`${environment.api}Oversea/${this.oversea_who_check}Checked?result=OK`, data, Settings.headers)
      this.service.show_success()
      this.get_oversea()
    } 
    catch (error) {
      this.service.show_error(error)
    }
  }

  async ngOverseaChecked(e:any){
    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(
      {
        ID: c
      })
    );
    try {
      await axios.post(`${environment.api}Oversea/${this.oversea_who_check}Checked?result=NG`, data, Settings.headers)
      this.service.show_success()
      this.get_oversea()
    } 
    catch (error) {
      this.service.show_error(error)
    }
  }

  async unOverseaChecked(e:any){
    let data : any[] = [];
    this.selectedItemKeys.forEach(c => data.push(
      {
        ID: c
      })
    );
    try {
      await axios.post(`${environment.api}Oversea/${this.oversea_who_check}Checked?result`, data, Settings.headers)
      this.service.show_success()
      this.get_oversea()
    } 
    catch (error) {
      this.service.show_error(error)
    }
  }


}

