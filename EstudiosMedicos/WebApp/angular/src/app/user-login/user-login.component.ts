import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators} from '@angular/forms';
import { Router} from '@angular/router';
import { UserServiceService } from '../services/user-service.service';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css'],
  providers: [UserServiceService]
})
export class UserLoginComponent implements OnInit {
  public formdata:FormGroup;

  constructor(private router: Router, private userService: UserServiceService) { }

  ngOnInit() {
    this.formdata = new FormGroup({
      uname: new FormControl("", Validators.compose([
         Validators.required,
         Validators.minLength(6)
      ])),
      passwd: new FormControl("", this.passwordvalidation)
   });
  }

  passwordvalidation(formcontrol) {
    if (formcontrol.value.length < 5) {
       return {"passwd" : true};
    }
  }

  onClickSubmit(data) {
    this.userService.ValidarUsuario(data.uname, data.passwd).subscribe(data => {
      if (data) {
        this.router.navigate(['app-mainpage'])
     } else {
        alert("Invalid Login");
        return false;
     }
    })
    
  }
}
