import { Component, enableProdMode, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}

@Component({
  selector: 'app-contract-center',
  templateUrl: './contract-center.component.html',
  styleUrls: ['./contract-center.component.scss']
})
export class ContractCenterComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
