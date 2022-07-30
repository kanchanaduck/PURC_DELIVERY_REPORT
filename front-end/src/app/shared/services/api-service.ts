import { enableProdMode, Injectable } from '@angular/core';
import axios from 'axios';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}

@Injectable()
export class Service {

  headers: any = {
    headers: {
    Authorization: 'Bearer ' + localStorage.getItem('token_purc_delivery_report'),
      'Content-Type': 'application/json'
    }
  }

  error: any;

  constructor() {}
  
  async sv_post(url: any,data: any) {
 console.log('sv_post',url)
      let response = await axios.post(environment.api + url,data);
      let dataS = response.data;
      console.log('sv_post dataS',dataS)
      let pushTobuyer=[];
      let pushTovendor=[];
      let pushTopartno=[];
      let pushTonopo=[];
        if(data.Type == 'Domestic'){
          for(let i = 0; i < response.data.length; i++){
            console.log(response.data[i])
            pushTobuyer.push(response.data[i].cd_procur_person)
            pushTovendor.push(response.data[i].cd_sply)
            pushTopartno.push(response.data[i].no_parts)
            pushTonopo.push(response.data[i].no_po)
          }
        }
        else if(data.Type == 'Oversea'){
          for(let i = 0; i < response.data.length; i++){
            pushTobuyer.push(response.data[i].cd_estim_person)
            pushTovendor.push(response.data[i].cd_sply)
            pushTopartno.push(response.data[i].no_parts)
            pushTonopo.push(response.data[i].no_po)
          }
        }
       let buyer = Array.from(new Set(pushTobuyer));
       let vendor = Array.from(new Set(pushTovendor));
       let partno = Array.from(new Set(pushTopartno));
       let nopo = Array.from(new Set(pushTonopo));
        console.log(buyer)
        console.log(vendor)
        console.log(partno)
        console.log(nopo)

      return { dataS , buyer ,vendor,partno,nopo};

  }

  async sv_get_grid(url: any,e: any,dt: any) {
    // try {
      let response = await axios.get(environment.api + url,dt);
      let dataS = response.data;
      let pushTobuyer=[];
      let pushTovendor=[];
      let pushTopartno=[];
      let pushTonopo=[];
        if(e == 'Domestic'){
          for(let i = 0; i < response.data.length; i++){
            pushTobuyer.push(response.data[i].cd_procur_person)
            pushTovendor.push(response.data[i].cd_sply)
            pushTopartno.push(response.data[i].no_parts)
            pushTonopo.push(response.data[i].no_po)
          }
        }
        else if(e == 'Oversea'){
          for(let i = 0; i < response.data.length; i++){
            pushTobuyer.push(response.data[i].cd_estim_person)
            pushTovendor.push(response.data[i].cd_sply)
            pushTopartno.push(response.data[i].no_parts)
            pushTonopo.push(response.data[i].no_po)
          }
        }
       let buyer = Array.from(new Set(pushTobuyer));
       let vendor = Array.from(new Set(pushTovendor));
       let partno = Array.from(new Set(pushTopartno));
       let nopo = Array.from(new Set(pushTonopo));


      return { dataS , buyer ,vendor,partno,nopo};

    // } catch (error) {
    //     console.error('sv_get url error: ',this.error.stack);
    //   return error
    // }
  }

  async sv_getreason(url: any){
   
    let response = await axios.get(environment.api + url);
    console.log('sv_getreason',response)
    return response.data
  }
  async sv_post_param(url: any,data: any){
    
    let response = await axios.post(environment.api + url,data);
    
    return response.data
  }
  async sv_post_paramEUC(url: any,data: string){

    let urls = environment.api + url + data;
    let response = await axios.post(urls);
  
    return response.data
  }

  async sv_form_data(url: any, formData: FormData) {
    try {
       const instance = axios.create({
        headers: {
          Authorization: 'application/json',
          'Content-Type': 'multipart/form-data',
          'cache-control': 'no-cache'
        },
      });
      const response = await instance.post(environment.api + url, formData);

      // return response.data;
    } catch (error:any) {
      console.log('RES ERROR: ', error.response);
     
    }
  }

  // async get_vendor() {
  //   let vendor:any = await axios.get(`${environment.api}Person/Vendor`, this.headers);
  //   return vendor;
  // } 

  // async get_buyer(){
  //   let buyer:any = await axios.get(`${environment.api}Person/Buyer`, this.headers);
  //   return buyer;
  // }

  // async get_part_no() {
  //   let part_no:any = await axios.get(`${environment.api}Person/PartNo`, this.headers);
  //   return part_no;
  // }
  getnopo() {
    return kpi_month;
  }

//--------------------Test Data----------------------//
  getkpi_month() {
    return kpi_month;
  }
  getEmployee() : Employee {
    return employee;
  }
  getPositions() : string[] {
    return positions;
  }
   getReportPUR12() : dailyPur12 {
    return dataPur12;
  }
  getEmployeePur12() : EmployeePur12 {
    return employee12pur;
  }
  getPositions12pur() : string[] {
    return positions12pur;
  }
  getEmployeesGrid12(): EmployeeGrid[] {
    return employeesgrid12;
  }
  getDomesticGrid12(): DomesticGridPUR12[] {
    return domesticgrid12;
  }

}

//--------------------Test Data----------------------//

  export class kpi_mnth {
    idkpi!: number;
    dept!: string;
    jan!: number;
    feb!: number;
    mar!: number;
    apr!: number;
    may!: number;
    jun!: number;
    jul!: number;
    aug!: number;
    sep!: number;
    oct!: number;
    nov!: number;
    dec!: number;
  }
  const kpi_month: kpi_mnth[]=[
    {
    idkpi:2,
    dept: "PUR 1",
    jan: 0.9797,
    feb: 0,
    mar: 0,
    apr: 0,
    may: 0,
    jun: 0,
    jul: 0,
    aug: 0,
    sep: 0,
    oct: 0,
    nov: 0,
    dec: 0},
    {
    idkpi:3,
    dept: "PUR 2",
    jan: 0.9853,
    feb: 0,
    mar: 0,
    apr: 0,
    may: 0,
    jun: 0,
    jul: 0,
    aug: 0,
    sep: 0,
    oct: 0,
    nov: 0,
    dec: 0},
  {
    idkpi:4,
    dept: "PUR 3",
    jan: 0.9754,
    feb: 0,
    mar: 0,
    apr: 0,
    may: 0,
    jun: 0,
    jul: 0,
    aug: 0,
    sep: 0,
    oct: 0,
    nov: 0,
    dec: 0
    }];

    export class Employee {
      ID!: number;
      FirstName!: string;
      LastName!: string;
      Position!: string;
      BirthDate!: string;
      HireDate!: string;
      Notes!: string;
      Address!: string;
      Phone!: string;
      Email!: string;
    }
    
    const employee: Employee = {
      ID: 1,
      FirstName: 'John',
      LastName: 'Heart',
      Position: 'CEO',
      BirthDate: '1964/03/16',
      HireDate: '1995/01/15',
      Notes: 'John has been in the Audio/Video industry since 1990. He has led DevAv as its CEO since 2003.\r\n\r\nWhen not working hard as the CEO, John loves to golf and bowl. He once bowled a perfect game of 300.',
      Address: '351 S Hill St., Los Angeles, CA',
      Phone: '360-684-1334',
      Email: 'jheart@dx-email.com'
    };

    const positions : string[] = [
      'HR Manager',
      'IT Manager',
      'CEO',
      'Controller',
      'Sales Manager',
      'Support Manager',
      'Shipping Manager',
    ];

    export class dailyPur12{
      ID!: number;
      report_daily!: string;
      applicant!: string;
      upload_date!: string;
      dept!:string;
      ext!:string;
      attachment!:string;
      remark!:string;
    }

    const dataPur12 : dailyPur12 = {
      ID: 1,
      report_daily: '',
      applicant: '',
      upload_date: '',
      dept:'',
      ext: '',
      attachment:'',
      remark:''
    }
  //----------------input reason Pur12--------------------------//
  export class EmployeePur12 {
    ID!: number;
    FirstName!: string;
    LastName!: string;
    Position!: string;
    BirthDate!: string;
    HireDate!: string;
    Notes!: string;
    Address!: string;
    Phone!: string;
    Email!: string;
  }
  
  const employee12pur : EmployeePur12 = {
    ID: 1,
    FirstName: 'John',
    LastName: 'Heart',
    Position: 'CEO',
    BirthDate: '1964/03/16',
    HireDate: '1995/01/15',
    Notes: 'John has been in the Audio/Video industry since 1990. He has led DevAv as its CEO since 2003.\r\n\r\nWhen not working hard as the CEO, John loves to golf and bowl. He once bowled a perfect game of 300.',
    Address: '351 S Hill St., Los Angeles, CA',
    Phone: '360-684-1334',
    Email: 'jheart@dx-email.com',
  };

  const positions12pur : string[] = [
    'CPT -> Must input "Detail of reason"',
    'Supplier -> Must input "Detail of reason"',
    'IMO -> Add order  (No Evidence)',
    'IMO -> Add order (with Evidence)',
    'LCD -> Add order (No Evidence)',
    'LCD -> Add order (with Evidence)',
    'LCD -> Pull-in (No Evidence)',
    'LCD -> Pull-in (with Evidence)',
    'LCD-> Must input "Detail of reason"',
    'LPD -> Add order (No Evidence)',
    'LPD -> Add order (with Evidence)',
    'LPD -> JIT',
    'LPD -> Pull-in (No Evidence)',
    'LPD -> Pull-in (with Evidence)',
    'LPD-> Must input "Detail of reason"',
    'PDC:ECN -> Add order (No Evidence)',
    'PDC:ECN -> Add order (with Evidence)',
    'PDC:ECN -> Pull-in (No Evidence)',
    'PDC:ECN -> Pull-in (with Evidence)',
    'PDC:Extra Work -> Add order (No Evidence)',
    'PDC:Extra Work -> Add order (with Evidence)',
    'PDC:Extra Work -> Pull-in (No Evidence)',
    'PDC:Extra Work -> Pull-in (with Evidence)',
    'PDC:New Model -> Add order (No Evidence)',
    'PDC:New Model -> Add order (with Evidence)',
    'PDC:New Model -> Pull-in (No Evidence)',
    'PDC:New Model -> Pull-in (with Evidence)',
    'PDC:Planning -> Add order (No Evidence)',
    'PDC:Planning -> Add order (with Evidence)',
    'PDC:Planning -> Add Plan  AO',
    'PDC:Planning -> CT Auto (Normal)',
    'PDC:Planning -> Pull-in (No Evidence)',
    'PDC:Planning -> Pull-in (with Evidence)',
    'PDC-> Must input "Detail of reason" Please issue dept.',
    'PMD -> Add order (No Evidence)',
    'PMD -> Add order (with Evidence)',
    'PMD -> Must input "Detail of reason" Please issue dept.',
    'PUR -> Add order (with Evidence)',
    'PUR -> Add order alternative part for support part delay',
    'PUR -> Cancel and re-issue because cant change delivery',
    'PUR -> Cancel and re-issue for change ECN number',
    'PUR -> Cancel and re-issue for revise unit price',
    'PUR -> Cancel-reissue for change ECN number',
    'PUR -> Must input "Detail of reason"',
    'SPM -> Add order (No Evidence)',
    'SPM -> Add order (with Evidence)',
    'SPM -> Add order short L/T',
    'SPM -> PO issue delay',
    'SPM -> Pull-in (No Evidence)',
    'SPM -> Pull-in (with Evidence)',
    'SPM-> Must input "Detail of reason"'
    
    
  ];

  export class EmployeeGrid {
    ID!: number;
    FirstName!: string;
    LastName!: string;
    Prefix!: string;
    Position!: string;
    Picture!: string;
    BirthDate!: string;
    HireDate!: string;
    Notes!: string;
    Address!: string;
  }
  const employeesgrid12: EmployeeGrid[] = [{
    ID: 1,
    FirstName: 'John',
    LastName: 'Heart',
    Prefix: 'Mr.',
    Position: 'CEO',
    Picture: 'images/employees/01.png',
    BirthDate: '1964/03/16',
    HireDate: '1995/01/15',
    Notes: 'John has been in the Audio/Video industry since 1990. He has led DevAv as its CEO since 2003.\r\n\r\nWhen not working hard as the CEO, John loves to golf and bowl. He once bowled a perfect game of 300.',
    Address: '351 S Hill St.',
  }, {
    ID: 20,
    FirstName: 'Olivia',
    LastName: 'Peyton',
    Prefix: 'Mrs.',
    Position: 'Sales Assistant',
    Picture: 'images/employees/09.png',
    BirthDate: '1981/06/03',
    HireDate: '2012/05/14',
    Notes: 'Olivia loves to sell. She has been selling DevAV products since 2012. \r\n\r\nOlivia was homecoming queen in high school. She is expecting her first child in 6 months. Good Luck Olivia.',
    Address: '807 W Paseo Del Mar',
  }, {
    ID: 4,
    FirstName: 'Robert',
    LastName: 'Reagan',
    Prefix: 'Mr.',
    Position: 'CMO',
    Picture: 'images/employees/03.png',
    BirthDate: '1974/09/07',
    HireDate: '2002/11/08',
    Notes: 'Robert was recently voted the CMO of the year by CMO Magazine. He is a proud member of the DevAV Management Team.\r\n\r\nRobert is a championship BBQ chef, so when you get the chance ask him for his secret recipe.',
    Address: '4 Westmoreland Pl.',
  }, {
    ID: 5,
    FirstName: 'Greta',
    LastName: 'Sims',
    Prefix: 'Ms.',
    Position: 'HR Manager',
    Picture: 'images/employees/04.png',
    BirthDate: '1977/11/22',
    HireDate: '1998/04/23',
    Notes: "Greta has been DevAV's HR Manager since 2003. She joined DevAV from Sonee Corp.\r\n\r\nGreta is currently training for the NYC marathon. Her best marathon time is 4 hours. Go Greta.",
    Address: '1700 S Grandview Dr.',
  }, {
    ID: 6,
    FirstName: 'Brett',
    LastName: 'Wade',
    Prefix: 'Mr.',
    Position: 'IT Manager',
    Picture: 'images/employees/05.png',
    BirthDate: '1968/12/01',
    HireDate: '2009/03/06',
    Notes: 'Brett came to DevAv from Microsoft and has led our IT department since 2012.\r\n\r\nWhen he is not working hard for DevAV, he coaches Little League (he was a high school pitcher).',
    Address: '1120 Old Mill Rd.',
  }];

  export class DomesticGridPUR12 {
    ID!: number;
    CD_SPLY!: string;
    NO_PO!: string;
    NO_PARTS!: string;
    NO_ADJ_DIM!: string;
    DT_PO!: string;
    DT_DELV!: string;
    TM_DELV!: string;
    DT_REC!: string;
    TM_REC!: string;
    DT_ACPTC!: string;
    CD_USE_BLOCK!: string;
    CD_PROCUR_PERSON!: string;
    Check_Short_LT1!: string;
    Check_Short_LT2!: string;
    Check_Early_OnTime_Delay!: string;
    Early_DV_Over_month!: string;
    IV_term!: string;
    TSS_Result!: string;
    MK_Short_LT!: string;
    Reason_Short_LT!: string;
    Detail_Short_LT_reason!: string;
    MK_Delay!: string;
    Reason_Delay!: string;
    Detail_delay_reason!: string;
    MK_Early!: string;
    Reason_Early!: string;
    Detail_Early_reason!: string;
    MK_DV!: string;
    Detail_Over_month_reason!: string;
    MK_IV!: string;
    Reason_IV!: string;
    MK_ONTIME!: string;
    status_reason!: string;
    reason_rk!: string;
  }

  const domesticgrid12: DomesticGridPUR12[] = [{
    ID: 1,
    CD_SPLY: "TAHG",
    NO_PO: "737130000",
    NO_PARTS: "FE3-0427-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "OK",
    reason_rk: ""
  }, {
    ID: 20,
    CD_SPLY: "TAHG",
    NO_PO: "737131000",
    NO_PARTS: "FE3-0795-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "NG",
    reason_rk: ""
  }, {
    ID: 4,
    CD_SPLY: "TAHG",
    NO_PO: "737134000",
    NO_PARTS: "FE3-0909-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 5,
    CD_SPLY: "TAHG",
    NO_PO: "737136000",
    NO_PARTS: "FE3-0923-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 6,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 7,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 8,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 9,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 10,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 11,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 12,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 13,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 14,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 15,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 16,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 17,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 18,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 19,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 21,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 22,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 23,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 24,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 25,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 26,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 27,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 28,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 29,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 30,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 31,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 32,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 33,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 34,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 35,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }, {
    ID: 36,
    CD_SPLY: "TAHG",
    NO_PO: "737137000",
    NO_PARTS: "FE3-0924-000",
    NO_ADJ_DIM: "000",
    DT_PO: "20211227",
    DT_DELV: "20220105",
    TM_DELV: "100000",
    DT_REC: "20220105",
    TM_REC: "125650",
    DT_ACPTC: "20220105",
    CD_USE_BLOCK: "55C1",
    CD_PROCUR_PERSON: "1K0131",
    Check_Short_LT1: "9",
    Check_Short_LT2: "9",
    Check_Early_OnTime_Delay: "0",
    Early_DV_Over_month: "OK",
    IV_term: "0",
    TSS_Result: "",
    MK_Short_LT: "",
    Reason_Short_LT: "",
    Detail_Short_LT_reason: "",
    MK_Delay: "",
    Reason_Delay: "",
    Detail_delay_reason: "",
    MK_Early: "",
    Reason_Early: "",
    Detail_Early_reason: "",
    MK_DV: "",
    Detail_Over_month_reason: "",
    MK_IV:"",
    Reason_IV: "",
    MK_ONTIME: "",
    status_reason: "",
    reason_rk: ""
  }];
  //--------------------Test Data-------------------------//



//---------------------------------------------------//