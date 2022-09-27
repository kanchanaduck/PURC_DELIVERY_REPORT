import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import axios from 'axios';
import { formatDate } from 'devextreme/localization';
import notify from 'devextreme/ui/notify';
import { Observable, lastValueFrom, catchError, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Settings } from './setting';
import jwt_decode from "jwt-decode";
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient, public router: Router) { }

  headers: any = Settings.headers.headers

  sendRequest(url: string, method = 'GET', data: any = {}): any {
    this.logRequest(method, url, data);

    const httpParams = new HttpParams({ fromObject: data ,});
    const httpOptions = { 
      withCredentials: false, 
      body: httpParams , 
      dataType: "json",
      headers: this.headers
    };
    let result: any;

    // alert(method)

    // console.log(data)

    switch (method) {
      case 'GET':
        result = this.http.get(`${environment.api}${url}`, httpOptions);
        break;
      case 'PUT':
        result = this.http.put(`${environment.api}${url}`, data, httpOptions);
        break;
      case 'POST':
        result = this.http.post(`${environment.api}${url}`, data, httpOptions);
        break;
      case 'DELETE':
        result = this.http.delete(`${environment.api}${url}`, httpOptions);
        break;
    }

    // console.log(result)

    return lastValueFrom(result)
      .then(
        (data: any) => ( method === 'GET' ? data : data) 
        )
      .catch((e: any) => {
        console.log(e)
        notify(e.error, 'error')
        throw e && e.error && e.error.Message;
      });
  }

  logRequest(method: string, url: string, data: object): void {
    // const args = Object.keys(data || {}).map((key) => `${key}=${data[key]}`).join(' ');

    const time = formatDate(new Date(), 'HH:mm:ss');

    // this.requests.unshift([time, method, url.slice(URL.length), args].join(' '));
  }


 // Create
 create(data: any): Observable<any> {
  let API_URL = `${environment.api}`;
  return this.http.post(API_URL, data)
    .pipe(
      catchError(this.handleError)
    )
}

// Read
async list(url:string) {
  // return this.http.get(`${environment.api}${url}`)
  // .pipe(
  //   catchError(this.handleError)
  // );
  return await this.http.get(`${environment.api}${url}`)
}


/* Update
update(id: any, data: any): Observable<any> {
  let API_URL = `${environment.api}/${id}`;
  return this.http.put(API_URL, data, { headers: this.headers }).pipe(
    catchError(this.handleError)
  )
} */

// Delete
delete(id: any): Observable<any> {
  var API_URL = `${environment.api}/${id}`;
  return this.http.delete(API_URL).pipe(
    catchError(this.handleError)
  )
}

// Handle API errors
handleError(error: HttpErrorResponse) {
  if (error.error instanceof ErrorEvent) {
    console.error('An error occurred:', error.error.message);
  } else {
    console.error(
      `Backend returned code ${error.status}, ` +
      `body was: ${error.error}`);
  }
  return throwError(
    'Something bad happened; please try again later.');
};

  // get_roles(){
  //   this.http.get(`${environment.api}Roles`).subscribe(lists => {
  //     console.log(lists)
  //     return lists;
  //   });
  // }

  show_success(){
    notify("Complete!", "success");
  }

  show_error(error: any){
    var text = typeof error.response.data === 'object'? error.response.data.title:error.response.data
    notify("Error! "+text, "error");
  }

  convertdate(str: string | number | Date) {
    var date = new Date(str),
      mnth = ("0" + (date.getMonth() + 1)).slice(-2),
      day = ("0" + date.getDate()).slice(-2);
    return [date.getFullYear(), mnth, day].join("");
  }

  service_jwt() {
    let token = sessionStorage.getItem('PURC_delivery_report_token');
    let decoded =  jwt_decode(token);

    // console.log('decoded: ',decoded);
    return decoded;
  }

  is_buyer(){
    let _user: any = this.service_jwt()
    if(_user.user.roles.includes("Buyer")){
      return true
    }
    return false;
  }

  is_purc(){
    let _user: any = this.service_jwt()
    if(_user.user.roles.includes("PURC")){
      return true
    }
    return false;
  }

  is_other(){
    let _user: any = this.service_jwt()
    if(_user.user.roles.includes("Other")){
      return true
    }
    return false;
  }

  is_manager(){
    let _user: any = this.service_jwt()
    if(_user.user.roles.includes("Manager")){
      return true
    }
    return false;
  }

  is_leader(){
    let _user: any = this.service_jwt()
    if(_user.user.roles.includes("Leader")){
      return true
    }
    return false;
  }

  expand_menu(): boolean{
    console.log("snapshot", this.router.url)
    return true;
  }

}
