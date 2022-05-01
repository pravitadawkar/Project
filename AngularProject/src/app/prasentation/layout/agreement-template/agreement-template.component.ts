import { Component, OnInit } from '@angular/core';
import { AgreementTemplateService } from 'src/app/core/services/agreement-template.service';
import{FormBuilder, FormGroup,FormControlName,FormControl} from '@angular/forms';
import { Validators } from '@angular/forms';
import { Router,ActivatedRoute } from '@angular/router';
import{Template} from '../../../core/models/Template'

@Component({
  selector: 'app-agreement-template',
  templateUrl: './agreement-template.component.html',
  styleUrls: ['./agreement-template.component.css']
})
export class AgreementTemplateComponent implements OnInit {
 ListallTemplate!:Template;
  TempaleAddForm!:FormGroup;
  constructor(private _TemplateService:AgreementTemplateService,private fb:FormBuilder,private route:Router,private router:ActivatedRoute) { 
    this.TempaleAddForm=this.fb.group({
      //id:['',Validators.required],
      firstName:['',Validators.required],
      lastName:['',Validators.required],
      address:['',Validators.required],
      emailAddress:['',Validators.required,Validators.email],
      dateOfBirth:['',Validators.required],
      gender:['',Validators.required],
      degree:['',Validators.required],
      joiningDate:['',Validators.required],
    })
  }
  get firstName(){
    return this.TempaleAddForm.get('firstName')
  }
  get lastName(){
    return this.TempaleAddForm.get('lastName')
  }
  get address(){
    return this.TempaleAddForm.get('address')
  }
  get emailAddress(){
    return this.TempaleAddForm.get('emailAddress')
  }
  get dateOfBirth(){
    return this.TempaleAddForm.get('dateOfBirth')
  }

  ngOnInit(): void {
    this._TemplateService.getAllTemplate().subscribe
    ( data =>
      {
        this.ListallTemplate=data
      });
  }
  get_alltemplates(){
    this._TemplateService.getAllTemplate().subscribe
    ( data =>
      {
        this.ListallTemplate=data
      });
  
  }
  //add template on button
 
  add_template(){
     console.warn(this.TempaleAddForm.value);
     this._TemplateService.postTemplate(this.TempaleAddForm.value).subscribe
    ( data =>
      {
        alert("template Added Successfully.")
       let btn= document.getElementById("closebtn");
       btn?.click();
        this.get_alltemplates();
        //this.route.navigate([''])
      });
  }
}
