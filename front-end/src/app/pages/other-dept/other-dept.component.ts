import { Component, enableProdMode, NgModule, OnInit, ViewChild } from '@angular/core';
import axios from 'axios';
import { DxFormComponent, 
         DxDataGridComponent,
         } from 'devextreme-angular';
import notify from 'devextreme/ui/notify';
import {  Service } from 'src/app/shared/services/api-service';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-other-dept',
  templateUrl: './other-dept.component.html',
  providers: [Service],
  styleUrls: ['./other-dept.component.scss']
})
export class OtherDeptComponent implements OnInit {
  @ViewChild(DxFormComponent, { static: false })
  myform!: DxFormComponent;
  @ViewChild("targetDataGridDomestic") dataGridDomestic!: DxDataGridComponent;
  @ViewChild("targetformTop") formSearch!: DxFormComponent;
  @ViewChild("Reasonform") PopupReason!: DxFormComponent;

  now: Date =  new Date();
  today = new Date();
  yesterday = new Date();
  DataReason: PopDataReason[];
  formtop!: dataformsearch;
  dataSourcesearch: any = [];
  datasearch: any = [];
  dataSourcePUR12: any = [];
  dataSourceOversea: any = [];
  refreshButtonOptions: any;
  positions: string[];
  selectedItemKeys: any[] = [];
  Arr_TSSResult: string[] = ['Effected','No Effected']
  status_Result: string[] = ['OK','NG']
  ReasonInput: any[] = [];
  getData:any[] = [];
  item:any[] = [];
  buyeritem: string[]= [];
  vendoritem: string[]= [];
  partnoitem: string[]= [];
  nopoitem: string[]= [];
  rsshortItem: string[] = [];
  rsdelayItem: string[] = [];
  rsearlyItem: string[] = [];
  updateItem: string[] = [];
  user:string;
  btnReasondisabled :boolean = false;
  DomesticGridVisible:boolean = true;
  OverseaGridVisible:boolean = false;
  popupVisible :boolean = false;
  closeButtonOptions: any;
  submitButtonOptions: any;
  priorities: string[];
  persearch = {
    Buyer: '1K0900',
    Vendor: '',
    Part_no: '',
    NO_PO: '',
    All: false,
    Short_LT: false,
    Delay: false,
    Early: false,
    Early_over_month: false,
    IV_Term: false,
    TSS:false,
    Type: 'Domestic',
    DateSH:this.convert(this.yesterday.setDate(this.today.getDate()- 1)),
    ToSH:this.convert(this.yesterday.setDate(this.today.getDate()- 1)),
    DateS: this.yesterday.setDate(this.today.getDate()- 1),
    ToS: this.yesterday.setDate(this.today.getDate()- 1)
  };
  datepipe: any;

  constructor(service: Service,
    public apiPUR: Service
    ) {
    const that = this;
    this.user = '013380'
    this.positions = service.getPositions12pur();
    this.DataReason = dataReason1;

    this.refreshButtonOptions = {
      icon: 'refresh',
      onClick: () => {
        that.refresh()
      },
    };
    this.submitButtonOptions = {
      text: 'Submit',
      onClick(e:any) {
        that.submit_reason(e);
        const message = 'Input reason finished.';
        notify({
          message,
          position: {
            my: 'center bottom',
            at: 'center bottom',
          },
        }, 'success', 2000);
        that.PopupReason.instance.resetValues();
        that.popupVisible = false;
      },
    };
    this.closeButtonOptions = {
      text: 'Close',
      onClick(e: any) {       
       that.PopupReason.instance.resetValues();
       that.popupVisible = false;
      },
    };
    this.priorities = [
      'Domestic',
      'Oversea'
    ];
    }
    buttonOptions = {
    text: "Search",
    type: "success",
    onClick:async (e:any)=>{
      if(this.persearch.Type == 'Oversea'){
        this.dataSourceOversea = [];
        this.dataSourceOversea =  await this.apiPUR.sv_post_param("input_Oversea/get_oversea_search",this.persearch);
      }
      if(this.persearch.Type == 'Domestic'){
        this.dataSourcePUR12 = [];
        this.dataSourceOversea = [];
        let overItem =  await this.apiPUR.sv_post_param("input_domestic/get_domestic_search",this.persearch);
        console.log('Search : ' ,overItem )
        this.dataSourcePUR12 = overItem;
      }
    }
    };

  ngOnInit(): void {
    this.persearch.Type 
    // Add 1 Day
    this.yesterday.setDate(this.today.getDate()- 1);
     this.get_grid('Domestic');

    const dataform = {
      ID: 1,
      Buyer: '',
      Vendor: '',
      Part_no: '',
      NO_PO: '',
      All: '',
      Short_LT: '',
      Delay: '',
      Early: '',
      Early_over_month: '',
      IV_Term: '',
      TSS: '',
      Type: '',
      DateSH: this.convert(this.yesterday),
      ToSH: this.convert(this.yesterday),
      DateS: this.yesterday,
      ToS: this.yesterday
    };
    this.formtop =  dataform;

  }
  ngAfterViewInit() {
    this.myform.instance.validate();
  }
  refresh() {
    console.log('refresh');
    this.dataGridDomestic.instance.refresh();
    this.dataSourcesearch = [];
    this.dataSourcePUR12 = [];
    this.datasearch = [];

    this.get_grid('Domestic');
}
  selectionChanged(data: any) {
    this.selectedItemKeys = data.selectedRowKeys;
    console.log('this.selectedItemKeys',this.selectedItemKeys)
    
  }
  onExporting(e: any) {
    console.log('onExporting',e)
    // const workbook = new Excel.Workbook();
    // const worksheet = workbook.addWorksheet('Employees');

    // exportDataGrid({
    //   component: e.component,
    //   worksheet,
    //   autoFilterEnabled: true,
    // }).then(() => {
    //   workbook.xlsx.writeBuffer().then((buffer) => {
    //     fs.saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'DataGrid.xlsx');
    //   });
    // });
    // e.cancel = true;

    // const workbook = new Excel.Workbook();    
    // const worksheet = workbook.addWorksheet('Main sheet');
    // exportPivotGrid({
    //     component: e.component,
    //     worksheet: worksheet
    // }).then(function() {
    //     workbook.xlsx.writeBuffer()
    //         .then(function(buffer: BlobPart) {
    //           fs.saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'PivotGrid.xlsx');
    //         });
    // });
    // e.cancel = true; 

  }
  showInfo(e: any) {
      this.popupVisible = true;
  }
  form_fieldDataChanged (e: any) {
    let updatedField = e.dataField;
    let newValue = e.value;
    let newValueformData = e.component.option("formData");
    this.ReasonInput = [{
      TSS_Result: newValueformData.TSS_Result,
      Reason_Short_LT: newValueformData.Reason_Short_LT,
      Detail_Short_LT_reason: newValueformData.Detail_Short_LT_reason,
      Reason_Delay: newValueformData.Reason_Delay,
      Detail_delay_reason: newValueformData.Detail_delay_reason,
      Reason_Early: newValueformData.Reason_Early,
      Detail_Early_reason: newValueformData.Detail_Early_reason,
      Detail_Over_month_reason: newValueformData.Detail_Over_month_reason,
      Reason_IV:newValueformData.Reason_IV
    }]
  }
  form_targetformTop(e: any){
     if(e.dataField == 'Type'  && e.value == 'Domestic'){
        this.DomesticGridVisible = true;
        this.OverseaGridVisible = false;

        this.get_grid(e.value);
        this.persearch.Type = e.value
     }
     else if(e.dataField == 'Type' && e.value == 'Oversea'){
        this.DomesticGridVisible = false;
        this.OverseaGridVisible = true;
        this.persearch.Type = e.value
        this.get_grid(e.value);
    }
    if(e.dataField == 'Buyer'){ this.persearch.Buyer = e.value}
    if(e.dataField == 'Vendor'){ this.persearch.Vendor = e.value}
    if(e.dataField == 'Part_no'){ this.persearch.Part_no = e.value}
    if(e.dataField == 'NO_PO'){ this.persearch.NO_PO = e.value}
    if(e.dataField == 'All'){ this.persearch.All = e.value}
    if(e.dataField == 'Short_LT'){ this.persearch.Short_LT = e.value}
    if(e.dataField == 'Delay'){ this.persearch.Delay = e.value}
    if(e.dataField == 'Early'){ this.persearch.Early = e.value}
    if(e.dataField == 'Early_over_month'){ this.persearch.Early_over_month = e.value}
    if(e.dataField == 'IV_Term'){ this.persearch.IV_Term = e.value}
    if(e.dataField == 'TSS'){ this.persearch.TSS = e.value}
    if(e.dataField == 'DateS'){
       let latest_date = this.convert(e.value);
       console.log( 'latest_date  Obj:' ,latest_date);
       this.persearch.DateSH =this.convert(e.value); 
       }
     if(e.dataField == 'ToS'){ 
       this.persearch.ToSH = this.convert(e.value); 
      }
   
  }
  convert(str: string | number | Date) {
  var date = new Date(str),
    mnth = ("0" + (date.getMonth() + 1)).slice(-2),
    day = ("0" + date.getDate()).slice(-2);
  return [date.getFullYear(), mnth, day].join("");
  }
  async get_db_EUC302(){
    try {
      const instance = axios.create({
          baseURL: "http://cptsvs531:1000/middleware/oracle/euc"
      });
      const body = {
          "command": `SELECT cd_sply_class,cd_sply,cd_sply_fact,cd_ord_class,no_po,no_split_deiv_sfx,no_parts,no_adj_dim,cd_process,no_draw,cd_chg_hist_all,dt_po,tm_po,qt_ord,dt_delv,tm_delv,dt_rec,tm_rec,qt_rec,dt_acptc,tm_acptc,qt_acptd,qt_ng,cd_delv_place,cd_destin,cd_use_block,cd_ord_resn,cd_insp_type_eiaj,cd_procur_person,no_ord_class
                      ,CM_COMENT,CF_RPT_PARTS_ORD 
                      FROM J302_ACCEPTANCE_SUM 
                      WHERE DT_ACPTC = '20220314' `

      }
      const res = await instance.post("", body)
      console.log(res.data)

  } catch (err) {
      console.log(err)
  }
  }
  async get_db_EUC327(){
    try {
      const instance = axios.create({
          baseURL: "http://cptsvs531:1000/middleware/oracle/euc"
      });
      const body = {
          "command": `SELECT  cd_sply_class,cd_sply,no_arrange,cd_sply_fact,no_po,no_invoice,no_split_deiv_sfx,
          no_parts,no_adj_dim,cd_process,no_draw,cd_chg_hist_all,dt_po,tm_po,qt_ord,dt_delv,
          tm_delv,dt_delv_estim,dt_delv_dirct,qt_delv_dirct,dt_delv_bal,dt_rec,tm_rec,qt_rec,
          qt_ng,cd_delv_place,cd_destin,cd_use_block,cd_insp_type_eiaj,cd_estim_person,
          cf_rpt_parts_ord,cd_ord_resn,cm_coment
          FROM J327_ACCEPTANCE_OVRSEA_SUM WHERE
          DT_REC BETWEEN '20220314' AND '20220314' `

      }
      const res = await instance.post("", body)
      console.log(res.data)

  } catch (err) {
      console.log(err)
  }
  }
  async get_grid(e: any){
    console.log('get_grid : ',e);
    let dataAPI;
    let DTSourceAPI;
    if(e == 'Domestic'){ 
    dataAPI = 'input_domestic/get_domestic_search' ;
    this.dataSourcesearch = [];
    this.dataSourceOversea = [];
    this.dataSourcePUR12 = [];
    DTSourceAPI = this.dataSourcePUR12;
  }
    else if(e == 'Oversea'){  
    dataAPI = 'input_Oversea/get_oversea_search' ;
    this.dataSourcesearch = [];
    this.dataSourceOversea = [];
    this.dataSourcePUR12 = [];
    DTSourceAPI = this.dataSourceOversea;
  }
  
    let dataGet =  await this.apiPUR.sv_post(dataAPI,this.persearch);
    this.dataSourcesearch = dataGet.dataS;
    this.dataSourceOversea = dataGet.dataS;
    this.dataSourcePUR12 = dataGet.dataS;
    this.buyeritem = dataGet.buyer;
    this.vendoritem = dataGet.vendor;
    this.partnoitem = dataGet.partno;
    this.nopoitem = dataGet.nopo;
    this.rsshortItem=  await this.apiPUR.sv_getreason("Reason/get_reason_dl_shortLT");
    this.rsdelayItem=  await this.apiPUR.sv_getreason("Reason/get_reason_delay");
    this.rsearlyItem=  await this.apiPUR.sv_getreason("Reason/get_reason_early");
    
  }
  async search_grid(){
    console.log('search_grid', this.dataSourcesearch )
  }
  async onEditingupdate(e: any): Promise<void> {
    if(this.persearch.Type == 'Domestic'){await this.apiPUR.sv_post_param("input_domestic/update_domestic_row",e.key)}
    else if(this.persearch.Type == 'Oversea'){await this.apiPUR.sv_post_param("input_Oversea/update_oversea_row",e.key)}
    
  }
  async submit_reason(e:any){
  let data : any[] = [];
  let Typeup = this.persearch.Type;
  this.selectedItemKeys.forEach(c => data.push(c.id));
  let Reasonup = [{
    id:data,
    TSS_Result: this.ReasonInput[0].TSS_Result,
    Reason_Short_LT: this.ReasonInput[0].Reason_Short_LT,
    Detail_Short_LT_reason: this.ReasonInput[0].Detail_Short_LT_reason,
    Reason_Delay: this.ReasonInput[0].Reason_Delay,
    Detail_delay_reason: this.ReasonInput[0].Detail_delay_reason,
    Reason_Early: this.ReasonInput[0].Reason_Early,
    Detail_Early_reason: this.ReasonInput[0].Detail_Early_reason,
    Detail_Over_month_reason: this.ReasonInput[0].Detail_Over_month_reason,
    Reason_IV:this.ReasonInput[0].Reason_IV,
    user: this.user
  }]
  console.log('submit_reason',Typeup);
  console.log('submit_reason Type',this.persearch.Type);
  if(Typeup == 'Domestic'){  console.log('submit_reason Domestic');  await this.apiPUR.sv_post_param("input_domestic/update_domestic_reason",Reasonup[0])}
  else if(Typeup =='Oversea'){ console.log('submit_reason Oversea');  await this.apiPUR.sv_post_param("input_Oversea/update_oversea_reason",Reasonup[0])}
  }
}

export class PopDataReason {
  ID!: number;
  TSS_Result!: string;
  Reason_Short_LT!: string;
  Detail_Short_LT_reason!: string;
  Reason_Delay!: string;
  Detail_delay_reason!: string;
  Reason_Early!: string;
  Detail_Early_reason!: string;
  Detail_Over_month_reason!: string;
  Reason_IV!: string;
}
const dataReason1 : PopDataReason[] = [{
  ID: 1,
  TSS_Result: '',
  Reason_Short_LT: '',
  Detail_Short_LT_reason: 'Test',
  Reason_Delay: '',
  Detail_delay_reason: '',
  Reason_Early: '',
  Detail_Early_reason:'',
  Detail_Over_month_reason: '',
  Reason_IV: ''
}];
export class dataformsearch {
  ID!: number;
  Buyer!: string;
  Vendor!: string;
  Part_no!: string;
  NO_PO!: string;
  All!: string;
  Short_LT!: string;
  Delay!: string;
  Early!: string;
  Early_over_month!: string;
  IV_Term!: string;
  TSS!: string;
  Type!: string;
  DateSH!:string;
  ToSH!:string;
  DateS!: Date;
  ToS!: Date;
}

function e(arg0: string, e: any) {
  throw new Error('Function not implemented.');
}
