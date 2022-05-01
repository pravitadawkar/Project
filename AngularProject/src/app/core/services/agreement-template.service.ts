import { Injectable } from '@angular/core';
import { Observable } from "rxjs";
import { HttpClient,HttpParams} from "@angular/common/http";
import{Template} from '../models/Template';


@Injectable({
  providedIn: 'root'
})
export class AgreementTemplateService {

  constructor(private httpclient:HttpClient) { }
  getAllTemplate():Observable<Template[]> {
    return this.httpclient.get<Template[]>("https://localhost:44390/api/EmpLeave/EmployeeLeaves");
}

postTemplate( model:Template):Observable<Template>{
    return this.httpclient.post<Template>("https://localhost:44390/api/EmpLeave/AddEmployeeLeave",model);
}
deleteTemplate(id:number):Observable<Template>{
    return this.httpclient.post<Template>("https://localhost:44390/api/EmpLeave/DeleteEmployeeLaeve?id="+id,'')
}
getTemplateById(Id:string):Observable<Template[]>{
    return this.httpclient.get<Template[]>("https://localhost:44390/api/EmpLeave/EmployeeLeaveById?id="+Id);
}
updateEmpleave(model:Template):Observable<Template>{
    return this.httpclient.post<Template>("https://localhost:44390/api/EmpLeave/UpdateEmployeeLeave",model)
}
}
