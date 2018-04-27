import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import 'rxjs/add/operator/map';

@Injectable()
export class UserServiceService {

  constructor(private http:HttpClient) { }

  ValidarUsuario(userName: string, password:string){
    return this.http.get('api/Usuario');
  }
}
