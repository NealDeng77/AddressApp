import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {
  addresses: any;
  
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getAddress();
  }

  /*
  get addresses from the API
  */
  getAddress() {
    this.http.get('http://localhost:5000/api/address').subscribe(response => {
    this.addresses = response;
    }, error =>{
      console.log(error);
    });
  }
}
