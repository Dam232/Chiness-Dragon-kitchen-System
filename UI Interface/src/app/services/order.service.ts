import { HttpBackend, HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  get_order_url: string ;
  put_update_status_url : string;
  BaseUrl                         : string = "http://localhost:10887/api/"
  constructor(private http: HttpClient, private httpBackend : HttpBackend) {
    this.get_order_url = this.BaseUrl +`China`;//http://localhost:10887/api/China
    this.put_update_status_url = this.BaseUrl + 'China';
   }


   getOrderDetails(): Observable<any> {
    return this.http.get<HttpResponse<Object>>(this.get_order_url)
   }

   putOrderStatus(orDataInf): Observable<any> {
    return this.http.put<HttpResponse<Object>>(this.put_update_status_url , orDataInf );
   }

  }
