import { Component, enableProdMode, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { DxDataGridModule } from 'devextreme-angular';
import notify from 'devextreme/ui/notify';
import { AppComponent } from 'src/app/app.component';
import { kpi_mnth, Service} from 'src/app/shared/services/api-service';

if (!/localhost/.test(document.location.host)) {
  enableProdMode();
}


@Component({
  selector: 'demo-app',
  templateUrl: 'home.component.html',
  styleUrls: [ './home.component.scss' ],
  providers: [Service],
})

export class HomeComponent {
  // dataSource: Employee[];
  dataSource: kpi_mnth[];
  selectBoxOptions: any;
  refreshButtonOptions: any;
  dateupOptions: string[] = ['02-11-2021', '02-12-2021', '02-01-2022', '14-02-2022', '18-02-2022', '19-02-2022'];

  constructor(service: Service) {
    this.dataSource = service.getkpi_month();

    this.refreshButtonOptions = {
        icon: 'refresh',
        onClick: () => {
          notify('Refresh button has been clicked!');
        },
      };
    this.selectBoxOptions = {
      width: 160,
      items: this.dateupOptions,
      // valueExpr: 'id',
      // displayExpr: 'text',
      value: this.dateupOptions[0],
      onValueChanged: (args: { value: number; }) => {
     
      },
    };
  }
}
@NgModule({
  imports: [
    BrowserModule,
    DxDataGridModule,
  ],
  // declarations: [AppComponent],
  bootstrap: [AppComponent],
})
export class AppModule { }

platformBrowserDynamic().bootstrapModule(AppModule);
