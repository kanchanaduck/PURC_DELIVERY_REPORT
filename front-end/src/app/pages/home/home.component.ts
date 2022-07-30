import { CUSTOM_ELEMENTS_SCHEMA, Component, enableProdMode, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
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
  dateupOptions: string[] = [ '2023','2022','2021' ];

  target: any = {};
  phoneOptions: any;

  constructor(service: Service) {
    this.dataSource = service.getkpi_month();
    
    this.target = {
      "monthly": 0,
      "yearly": 0
    }

    this.phoneOptions = this.generateNewButtonOptions();

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
        let year = args.value
        console.log(year)
      },
    };
  }

  form_upload (e: any) {
    console.log(e)
    // if(e.dataField == "domestic" && e.value != null)
  }


  generateNewButtonOptions() {
    return {
      buttons: [
        {
          name: '%',
          location: 'after',
          options: {
            stylingMode: 'text',
            text: '%',
          },
        },
        {
          name: 'trash',
          location: 'after',
          options: {
            stylingMode: 'contained',
            icon: 'save',
            type: "success",
            onClick: () => {
              alert("Save")
            },
          },
        }
      ],
    };
  }

}
@NgModule({
  imports: [
    BrowserModule,
  ],
  // declarations: [AppComponent],
  bootstrap: [AppComponent],
})
export class AppModule { }

platformBrowserDynamic().bootstrapModule(AppModule);
