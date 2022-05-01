import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AgreemrntTemplateRoutingModule } from './agreemrnt-template-routing.module';
import{AgreementTemplateComponent}from './../../layout/agreement-template/agreement-template.component'
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule,HTTP_INTERCEPTORS } from '@angular/common/http';
import{InterceptorService} from './../../../core/interceptors/interceptor.service'

@NgModule({
  declarations: [
    AgreementTemplateComponent
  ],
  imports: [
    CommonModule,
    AgreemrntTemplateRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers:[
    {
      provide:HTTP_INTERCEPTORS,useClass:InterceptorService,multi:true}]
})
export class AgreemrntTemplateModule { }
