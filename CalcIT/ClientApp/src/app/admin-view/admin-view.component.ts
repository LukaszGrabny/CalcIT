import { HttpClient } from '@angular/common/http';
import {Component, Inject} from '@angular/core';
import { Router } from '@angular/router';
declare var require: any

@Component({
    selector: 'admin-view',
    templateUrl: 'admin-view.component.html',
  })
  export class AdminView {
    // imgCancel= require("../images/cancel.png");


constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route:Router){
  }
  }
  