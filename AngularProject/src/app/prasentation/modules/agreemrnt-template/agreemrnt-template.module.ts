import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AgreemrntTemplateRoutingModule } from './agreemrnt-template-routing.module';
import{AgreementTemplateComponent}from './../../layout/agreement-template/agreement-template.component'

@NgModule({
  declarations: [
    AgreementTemplateComponent
  ],
  imports: [
    CommonModule,
    AgreemrntTemplateRoutingModule
  ]
})
export class AgreemrntTemplateModule { }
