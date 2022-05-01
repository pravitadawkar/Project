import { Component, OnInit } from '@angular/core';
import{FormBuilder, FormGroup,FormControlName, FormControl} from '@angular/forms';
import { Validators } from '@angular/forms';
import{AuthService} from '../../../core/services/auth.service';
import{Router} from '@angular/router'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm=new FormGroup({
    username:new FormControl('',Validators.required),
    password:new FormControl('',Validators.required)
  })

  constructor( private authservice:AuthService,private router:Router) { }
  

  ngOnInit(): void {
  }
  loginform(){
    this.authservice.loginForm(this.loginForm.value).subscribe(data =>{
      alert('login successfully!');
      localStorage.setItem('token',data.token);
    })
  }
  get username(){
    return this.loginForm.get('username')
  }
  get password(){
    return this.loginForm.get('password')
  }


}
