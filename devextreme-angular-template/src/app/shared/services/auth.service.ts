import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot } from '@angular/router';
import notify from 'devextreme/ui/notify';
import { environment } from 'src/environments/environment';
import { Settings } from './setting';

const defaultPath = '/';
// const defaultUser = {
//   username: '014496',
// };

@Injectable()
export class AuthService {

  private _user: any;
  get loggedIn(): boolean {
    return !!sessionStorage.getItem("PURC_delivery_report_token")
  }


  private _lastAuthenticatedPath: string = defaultPath;
  set lastAuthenticatedPath(value: string) {
    this._lastAuthenticatedPath = value;
  }

  constructor(private router: Router, private http: HttpClient) { }



  logIn(username: string, password: string){
    // return defaultUser;

    // console.log("Login")
    this.http.post(`${environment.api}Login`,{
      username: username,
      password: password
    }).subscribe(
      (response) => { 
        this._user=response
        // console.log(this._user)
        sessionStorage.setItem("PURC_delivery_report_token", this._user.token)
        sessionStorage.setItem("PURC_delivery_report_name", this._user.name)
        location.href = `home`
      },
      (error) => { 
        console.log(error);
        notify("Authentication failed.","error",3000)
      }
    );

  }

  async getUser() {
    return {
      isOk: true,
      data: sessionStorage.getItem("PURC_delivery_report_name")
    };
  }

  async createAccount(username, password) {
    try {
      console.log(username, password);

      this.router.navigate(['/create-account']);
      return {
        isOk: true
      };
    }
    catch {
      return {
        isOk: false,
        message: "Failed to create account"
      };
    }
  }

  async changePassword(formData: any) {
    this.http.post(`${environment.api}User/ChangePassword`,formData, Settings.headers).subscribe(
      (response) => { 
        this._user=response
      },
      (error) => { 
        console.log(error);
        notify("Chnage password failed.","error",3000)
      }
    );

    return {
      isOk: true,
      data: this._user,
      message: "Failed to change password"
    };
  }

  async resetPassword(username: string) {
    try {
      console.log(username);

      return {
        isOk: true
      };
    }
    catch {
      return {
        isOk: false,
        message: "Failed to reset password"
      };
    }
  }

  async logOut() {
    this._user = null;
    sessionStorage.removeItem("PURC_delivery_report_token")
    sessionStorage.removeItem("PURC_delivery_report_name")
    location.href = "#/login-form"
  }
}

@Injectable()
export class AuthGuardService implements CanActivate {
  constructor(private router: Router, private authService: AuthService) { }

  canActivate(route: ActivatedRouteSnapshot): boolean {
    const isLoggedIn = this.authService.loggedIn;
    const isAuthForm = [
      'login-form',
      'reset-password',
      'create-account',
      'change-password/:recoveryCode'
    ].includes(route.routeConfig.path);



    if (!isLoggedIn && !isAuthForm) {
      this.router.navigate(['/login-form']);
    }

    return true;
  } 
}