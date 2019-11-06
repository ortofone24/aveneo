import { Component, OnInit } from '@angular/core';
import { BusinessEntityService } from '../_services/businessEntity.service';
import { delay } from 'q';



@Component({
  selector: 'app-aveneo',
  templateUrl: './aveneo.component.html',
  styleUrls: ['./aveneo.component.css']
})
export class AveneoComponent {

  model: any = {};
  businessEntitiesResponse: any;
  errorMessage = '';

  constructor(private businessEntityService: BusinessEntityService) {}

  log(x) {
    console.log(x);
  }

  getSearchQuery() {
    this.errorMessage = '';
    const temp = this.getDigits(this.model.searchQuery);
    console.log(temp);
    this.businessEntityService.getBusinessEntity(temp)
    .subscribe(
      data => {
        this.businessEntitiesResponse = data;
      }, (err) => {
        console.log(err);
        this.errorMessage = 'Nie znaleziono takiego wpisu';
      }
    );
  }

  getDigits(stringCandidate: string): string {
    let value = '';
    const arrayFromStringCandidate = Array.from(stringCandidate);
    for (let i = 0; i <= arrayFromStringCandidate.length; i++) {
      if (arrayFromStringCandidate[i] >= '0' && arrayFromStringCandidate[i] <= '9') {
        value += arrayFromStringCandidate[i];
      }
    }
    return value;
  }
}
