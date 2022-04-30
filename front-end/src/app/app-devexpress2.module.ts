import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppComponent } from './app.component';
// import { DxFileUploaderModule, DxTextAreaModule ,DxButtonModule} from 'devextreme-angular';
// import { DxButtonModule } from'devextreme-angular/ui/button';
import { DxFormComponent } from 'devextreme-angular';
import { DxFileUploaderModule } from 'devextreme-angular/ui/file-uploader';
import { DxTextAreaModule } from 'devextreme-angular/ui/text-area';
import { DxButtonModule } from 'devextreme-angular/ui/button';


@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    AppComponent,
    DxFormComponent,
    DxFileUploaderModule,
    DxTextAreaModule,
    DxButtonModule
  ],
  exports: [ 
    DxFormComponent,
    DxFileUploaderModule,
    DxTextAreaModule,
    DxButtonModule
  ]
})
export class AppDevexpress2Module { }
