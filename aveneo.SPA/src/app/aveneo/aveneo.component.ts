import { Component, OnInit } from '@angular/core';
import { BusinessEntityService } from '../_services/businessEntity.service';




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

  onKey(event: any) {
    this.errorMessage = '';
    this.businessEntitiesResponse = null;
  }

  getSearchQuery() {
    this.errorMessage = '';
    this.businessEntitiesResponse = null;
    const temp = this.getDigits(this.model.searchQuery);
    this.businessEntityService.getBusinessEntity(temp)
    .subscribe(
      data => {
        this.businessEntitiesResponse = data;
      }, (err) => {
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
