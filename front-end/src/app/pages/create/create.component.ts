import { Component, enableProdMode, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';

if (environment.production) {
  enableProdMode();
}
@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
