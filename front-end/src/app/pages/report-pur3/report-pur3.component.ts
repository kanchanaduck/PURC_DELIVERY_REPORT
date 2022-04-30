import { Component, enableProdMode,  NgModule,  OnInit, ViewChild } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import axios from 'axios';
import {DxFormComponent,DxFileUploaderModule, DxTextAreaModule ,DxButtonModule} from 'devextreme-angular';
import notify from 'devextreme/ui/notify';
import { AppComponent } from 'src/app/app.component';
import { dailyPur12, Service } from 'src/app/shared/services/api-service';
import { environment } from 'src/environments/environment';

// if (!/localhost/.test(document.location.host)) {
//   enableProdMode();
// }

if (environment.production) {
  enableProdMode();
}
@Component({
  selector: 'app-report-pur3',
  providers: [Service],
  templateUrl: './report-pur3.component.html',
  styleUrls: ['./report-pur3.component.scss']
})
export class ReportPur3Component implements OnInit {
  @ViewChild("formuploadfiles") formupload!: DxFormComponent;

  dataPur12: dailyPur12;
  refreshButtonOptions: any;
  fileDel_Do: any;
  fileDel_Do_name: any;
  fileDel_Over: any;
  fileDel_Over_name: any;
  filePO: any;
  filePO_name: any;
  fileDelay_Do: any;
  fileDelay_Do_name: any;
  fileDelay_Over: any;
  fileDelay_Over_name: any;
  filePU: any;
  filePU_name: any;
  fileDel_Evolio: any;
  fileDel_Evolio_name: any;
  fileShortLT: any;
  fileShortLT_name: any;
  loadingVisible = false;

  constructor(service: Service,
    public apiPUR: Service) {
    this.dataPur12 = service.getReportPUR12();
    this.refreshButtonOptions = {
      icon: 'refresh',
      onClick: () => {
        notify('Refresh button has been clicked!');
      },
    };
    
   }

  ngOnInit(): void {
  }
  buttonConfirm = {
    text: "Confirm",
    type: "success",
    onClick: async () => {
      let formData = new FormData();
      this.loadingVisible = true;
      if (this.fileDel_Do !== undefined && this.fileDel_Do !== "" && this.fileDel_Do !== null) {
        formData.append('fileDel_Do', this.fileDel_Do)
        formData.append('fileDel_Do_name', this.fileDel_Do_name)
      }
      if (this.fileDel_Over !== undefined && this.fileDel_Over !== "" && this.fileDel_Over !== null) {
        formData.append('fileDel_Over', this.fileDel_Over)
        formData.append('fileDel_Over_name', this.fileDel_Over_name)
      }
      if (this.filePO !== undefined && this.filePO !== "" && this.filePO !== null) {
        formData.append('filePO', this.filePO)
        formData.append('filePO_name', this.filePO_name)
      }
      if (this.fileDelay_Do !== undefined && this.fileDelay_Do !== "" && this.fileDelay_Do !== null) {
        formData.append('fileDelay_Do', this.fileDelay_Do)
        formData.append('fileDelay_Do_name', this.fileDelay_Do_name)
      }
      if (this.fileDelay_Over !== undefined && this.fileDelay_Over !== "" && this.fileDelay_Over !== null) {
        formData.append('fileDelay_Over', this.fileDelay_Over)
        formData.append('fileDelay_Over_name', this.fileDelay_Over_name)
      }
      if (this.filePU !== undefined && this.filePU !== "" && this.filePU !== null) {
        formData.append('filePU', this.filePU)
        formData.append('filePU_name', this.filePU_name)
      }
      if (this.fileDel_Evolio !== undefined && this.fileDel_Evolio !== "" && this.fileDel_Evolio !== null) {
        formData.append('fileDel_Evolio', this.fileDel_Evolio)
        formData.append('fileDel_Evolio_name', this.fileDel_Evolio_name)
      }
      if (this.fileShortLT !== undefined && this.fileShortLT !== "" && this.fileShortLT !== null) {
        formData.append('fileShortLT', this.fileShortLT)
        formData.append('fileShortLT_name', this.fileShortLT_name)
      }


      formData.append('update_by', '013380')
      formData.append('subject', 'Report 19 Apr 22')
     
      await this.apiPUR.sv_form_data('input_filereason/upload_file', formData);
    }
  };
  buttonCancel = {
    text: "Cancel",
    type: "normal",
    onClick: function () {
        // Implement your logic here
    }
  };
  showMessage = () => {
    notify("The button was clicked");
  } 
  btnsave(e: any){
    console.log('btnsave',e)

  }
  onUploadProgress(e: any) {
    console.log('onUploadProgress',e)
  }
  getChunkPanel() {
    return document.querySelector('.chunk-panel');
  }
  onUploadDeliDomes(e: any) {
    this.fileDel_Do = e.file;
    this.fileDel_Do_name = e.file.name;
  }
  onUploadDeliOver(e: any) {
    this.fileDel_Over = e.file;
    this.fileDel_Over_name = e.file.name;
  }
  onUploadPO(e: any) {
    this.filePO = e.file;
    this.filePO_name = e.file.name;
  }
  onUploadDelayDomes(e: any) {
    this.fileDelay_Do = e.file;
    this.fileDelay_Do_name = e.file.name;
  }
  onUploadDelayOver(e: any) {
    this.fileDelay_Over = e.file;
    this.fileDelay_Over_name = e.file.name;
  }
  onUploadPU(e: any) {
    this.filePU = e.file;
    this.filePU_name = e.file.name;
  }
  onUploadDeliEvalio(e: any) {
    this.fileDel_Evolio = e.file;
    this.fileDel_Evolio_name = e.file.name;
  }
  onUploadShortLT(e: any) {
    this.fileShortLT = e.file;
    this.fileShortLT_name = e.file.name;
  }
  onShown() {
    setTimeout(() => {
      this.loadingVisible = false;
    }, 7000);
  }
  onHidden() {
    notify("Complete!");
    this.formupload.instance.resetValues();
  }
}
