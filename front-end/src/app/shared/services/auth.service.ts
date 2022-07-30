import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot } from '@angular/router';
import axios, { AxiosResponse } from 'axios';
import { environment } from 'src/environments/environment';

export interface IUser {
  username?: any;
  avatarUrl?: string
}

const defaultPath = `/`;

// const defaultUser = null;


// const defaultUser =  {
//   username: null,
//   avatarUrl: '/images/employees/06.png'
// };

@Injectable()
export class AuthService {
  // private _user: IUser | null = defaultUser;
  private _user:any = null;
  get loggedIn(): boolean {
    return !!this._user;
  }

  private _lastAuthenticatedPath: string = defaultPath;
  set lastAuthenticatedPath(value: string) {
    this._lastAuthenticatedPath = value;
  }

  constructor(private router: Router) { }

  async logIn(username: string, password: string) {
    try {
      console.log(username, password);
      // this._user = { ...defaultUser, username };
      // this._user =  { ...defaultUser, username };

      

      // try {
        let response = await axios.post(`${environment.api}Login`,{
          username: username, 
          password: password
        })
        this._user = response.data
      //   console.log(response)
      //   // .then(function(response){
      //   //   console.log(response)
      //   //   // this._user = response.data
      //   // })
      //   // .catch(function(e){
      //   //   console.log(e)
      //   // })
      // } catch (error) {
      //   console.log(error)
      // }


      // this._user = { defaultUser,  }

      this.router.navigate([this._lastAuthenticatedPath]);

      return {
        isOk: true,
        data: this._user
      };
    }
    catch(error: any) {
      return {
        isOk: false,
        // message: "Authentication failed"
        message: typeof error.response.data === 'object'? error.response.data.title:error.response.data
      };
    }
  }

  async getUser() {
    try {
      // Send request

      return {
        isOk: true,
        data: this._user
      };
    }
    catch {
      return {
        isOk: false,
        data: null
      };
    }
  }

  async createAccount(username: string, password: string) {
    try {
      // Send request
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

  async changePassword(username: string, recoveryCode: string) {
    try {
      // Send request
      console.log(username, recoveryCode);

      return {
        isOk: true
      };
    }
    catch {
      return {
        isOk: false,
        message: "Failed to change password"
      }
    };
  }

  async resetPassword(username: string) {
    try {
      // Send request
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
    this.router.navigate(["/login-form"]);
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
    ].includes(route.routeConfig?.path || defaultPath);

    console.log("isLoggedIn", isLoggedIn)
    console.log("isAuthForm", isAuthForm)

    if (isLoggedIn && isAuthForm) {
      console.log(1)
      this.authService.lastAuthenticatedPath = defaultPath;
      this.router.navigate([defaultPath]);
      return false;
    }

    if (!isLoggedIn && !isAuthForm) {
      console.log(2)
      this.router.navigate(['/login-form']);
    }

    if (isLoggedIn) {
      console.log(3)
      this.authService.lastAuthenticatedPath = route.routeConfig?.path || defaultPath;
    }

    return isLoggedIn || isAuthForm;
  } 
}