import { Component, OnInit } from '@angular/core';
import CustomStore from 'devextreme/data/custom_store';
import { ApiService } from 'src/app/shared/services/api.service';

@Component({
  selector: 'app-reason',
  templateUrl: './reason12.component.html',
  styleUrls: ['./reason12.component.scss']
})
export class Reason12Component {

  reason_domestic_shortlt: any = [];
  reason_domestic_delay: any = [];
  reason_domestic_early: any = [];

  reason_oversea_shortlt: any = [];
  reason_oversea_delay: any = [];
  reason_oversea_early: any = [];


  refreshModes: string[];
  refreshMode: string;

  is_purc: boolean = false;

  constructor(public service: ApiService) { 
    this.refreshMode = 'reshape';
    this.refreshModes = ['full', 'reshape', 'repaint'];

    this.is_purc = this.service.is_purc();

    this.reason_domestic_shortlt = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/PUR12/Domestic/ShortLT`),
      insert: (values) => this.service.sendRequest(`Reason/PUR12/Domestic/ShortLT`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/PUR12/Domestic/ShortLT/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/PUR12/Domestic/ShortLT/${key}`, 'DELETE'),
    });

    this.reason_domestic_delay = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/PUR12/Domestic/Delay`),
      insert: (values) => this.service.sendRequest(`Reason/PUR12/Domestic/Delay`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/PUR12/Domestic/Delay/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/PUR12/Domestic/Delay/${key}`, 'DELETE'),
    });

    this.reason_domestic_early = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/PUR12/Domestic/Early`),
      insert: (values) => this.service.sendRequest(`Reason/PUR12/Domestic/Early`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/PUR12/Domestic/Early/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/PUR12/Domestic/Early/${key}`, 'DELETE'),
    });

    
    this.reason_oversea_shortlt = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/PUR12/Oversea/ShortLT`),
      insert: (values) => this.service.sendRequest(`Reason/PUR12/Oversea/ShortLT`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/PUR12/Oversea/ShortLT/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/PUR12/Oversea/ShortLT/${key}`, 'DELETE'),
    });

    this.reason_oversea_delay = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/PUR12/Oversea/Delay`),
      insert: (values) => this.service.sendRequest(`Reason/PUR12/Oversea/Delay`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/PUR12/Oversea/Delay/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/PUR12/Oversea/Delay/${key}`, 'DELETE'),
    });

    this.reason_oversea_early = new CustomStore({
      key: 'id',
      load: () => this.service.sendRequest(`Reason/PUR12/Oversea/Early`),
      insert: (values) => this.service.sendRequest(`Reason/PUR12/Oversea/Early`, 'POST', values),
      update: (key, values) => this.service.sendRequest(`Reason/PUR12/Oversea/Early/${key}`, 'PUT', values),
      remove: (key) => this.service.sendRequest(`Reason/PUR12/Oversea/Early/${key}`, 'DELETE'),
    });
  }

}
