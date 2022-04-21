import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import{AgreementTemplateComponent} from './../../layout/agreement-template/agreement-template.component'

const routes: Routes = [
  {path:'',component:AgreementTemplateComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AgreemrntTemplateRoutingModule { }
