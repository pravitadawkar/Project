import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//import { AgreemrntTemplateModule } from './prasentation/modules/agreemrnt-template/agreemrnt-template.module';
import{AgreementTemplateComponent} from './../app/prasentation/layout/agreement-template/agreement-template.component'
const routes: Routes = [
  // {path:'agreement_template',loadChildren:() =>
  // import('./prasentation/modules/agreemrnt-template/agreemrnt-template.module').then((m) =>AgreemrntTemplateModule)}
{path:'agreement-template',component:AgreementTemplateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
