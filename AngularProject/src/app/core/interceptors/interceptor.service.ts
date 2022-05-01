import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable, Injector } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import{AuthService} from '../services/auth.service'
@Injectable({
  providedIn: 'root'
})
export class InterceptorService  implements HttpInterceptor {

  constructor( private authservice:AuthService) { }
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
   
    const token=this.authservice.getToken();
    //alert(token);
    if(token){
      const request = req.clone({headers:req.headers.set('Authorization',`Bearer ${token}`)});
      return next.handle(request);
      
    }
    return next.handle(req);
   }
 }

