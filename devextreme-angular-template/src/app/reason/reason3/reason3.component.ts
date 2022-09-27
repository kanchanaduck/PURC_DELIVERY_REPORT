import { Component, OnInit } from '@angular/core';
import CustomStore from 'devextreme/data/custom_store';
import { ApiService } from 'src/app/shared/services/api.service';

@Component({
  selector: 'app-reason',
  templateUrl: './reason3.component.html',
  styleUrls: ['./reason3.component.scss']
})
export class Reason3Component {

  reason_delay_domestic: any = [];
  reason_delay_oversea: any = [];
  reason_evalio: any = [];


  refreshModes: string[];
  refreshMode: string;

  constructor(public service: ApiService) { 
    this.refreshMode = 'reshape';
    this.refreshModes = ['full', 'reshape', 'repaint'];

    this.reason_delay_domestic = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/DelayDomestic`),
      insert: (values) => this.service.sendRequest(`Reason/DelayDomestic`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/DelayDomesticT/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/DelayDomestic/${key}`, 'DELETE'),
    });

    this.reason_delay_oversea = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/DelayOversea`),
      insert: (values) => this.service.sendRequest(`Reason/DelayOversea`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/DelayOversea/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/DelayOversea/${key}`, 'DELETE'),
    });

    this.reason_evalio = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/ControlEvalio`),
      insert: (values) => this.service.sendRequest(`Reason/ControlEvalio`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/ControlEvalio/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/ControlEvalio/${key}`, 'DELETE'),
    });
  }

}
