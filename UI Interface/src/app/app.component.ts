import { Component, OnInit } from '@angular/core';
import { OderDisplayMock } from './mockData/orderDisplay';
import { ResponseBean } from './models/response/ResponseBean';
import { OrderService } from './services/order.service';
import {OrderDataInf} from './mockData/Interfaces/order'
import { dynamicField } from './models/editStatusModel';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent  implements OnInit {
  title = 'ChinesDragon';

  public responseBean: ResponseBean;

  public changeStatus : string;
  public countQueue : number;
  public countPrepaired : number;
  public countCancelled : number;
  public errorMessage: string;
  public warningMessage: string;
  public orderDetailsList = [];
  //data1 = OderDisplayMock

  constructor(
    public orderService: OrderService
  ) {}

  ngOnInit() {
    this.loadOrderDetails(); //--(1)

    //----------------------------------------------------------------------------------------(2)
   /*this.orderDetailsList = OderDisplayMock
   this.countQueue = this.orderDetailsList.filter(obj => obj.Status === "In Queue").length;
   this.countPrepaired = this.orderDetailsList.filter(obj => obj.Status === "Mark Prepared").length;
   this.countCancelled = this.orderDetailsList.filter(obj => obj.Status === "Cancelled").length;
   console.log(this.countQueue)*/
   //----------------------------------------------------------------------------------------(2)
  }
  

  loadOrderDetails() {

    this.orderService.getOrderDetails().subscribe(
      data => {
        this.responseBean = data;
        console.log(data)
        this.orderDetailsList =data;

        this.countQueue = this.orderDetailsList.filter(obj => obj.Status === "In Queue").length;
         this.countPrepaired = this.orderDetailsList.filter(obj => obj.Status === "Mark Prepared").length;
          this.countCancelled = this.orderDetailsList.filter(obj => obj.Status === "Cancelled").length;
          console.log(this.countQueue)
        /*if (this.responseBean.responseCode === RESPONSE_SUCCESS ){
          this.orderDetailsList = this.responseBean.content;
        }*/
      }, err => {
        this.responseBean = err.error;
        alert('Error!! :-)\n\n' + err.error);
      }
    )
  }



  public StatusUpdate(status: string, OrdeRreference : string) {

    var orDataInf = new dynamicField;

    

    console.log("Put");
    console.log(orDataInf);

    if(status == "In Queue"){
      this.changeStatus = "Start Preparing"
    }
    else if(status == "Start Preparing"){
      this.changeStatus = "Mark Prepared"
    }
  else {
      this.changeStatus = "Picked" 
    }

    orDataInf.OrdeRreference = OrdeRreference,
    orDataInf.Status = this.changeStatus;
    this.orderService.putOrderStatus(orDataInf).subscribe(
      (response) => {
         this.responseBean = response;
          alert('SUCCESS!!');
          this.loadOrderDetails();
         console.log('Success******************************************');
      },
       err => {
        this.responseBean = err.error;
        alert('Error!! :-)\n\n' + err.error);

      }
    )
  }
}


