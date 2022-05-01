import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//import { AgreemrntTemplateModule } from './prasentation/modules/agreemrnt-template/agreemrnt-template.module';
import{AgreementTemplateComponent} from './../app/prasentation/layout/agreement-template/agreement-template.component'
import { AuthGuard } from './core/guards/auth.guard';
import { LoginComponent } from './prasentation/layout/login/login.component';
const routes: Routes = [
  // {path:'agreement_template',loadChildren:() =>
  // import('./prasentation/modules/agreemrnt-template/agreemrnt-template.module').then((m) =>AgreemrntTemplateModule)}
 {path:'login',component:LoginComponent },
 {path:'',redirectTo:'/login',pathMatch:'full'},
  {path:'agreement-template',component:AgreementTemplateComponent,canActivate:[AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
