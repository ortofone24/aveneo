import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-aveneo',
  templateUrl: './aveneo.component.html',
  styleUrls: ['./aveneo.component.css']
})
export class AveneoComponent implements OnInit {

  buisnessEntity: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getBusinessEntity();
  }

  getBusinessEntity() {
    this.http.get('https://localhost:44335/api/BusinessEntity/333333333/').subscribe(response => {
    this.buisnessEntity = response;
    }, error => {
      console.log(error);
      });
  }
}
