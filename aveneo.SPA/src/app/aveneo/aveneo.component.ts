import { Component, OnInit } from '@angular/core';
import { BusinessEntityService } from '../_services/businessEntity.service';


@Component({
  selector: 'app-aveneo',
  templateUrl: './aveneo.component.html',
  styleUrls: ['./aveneo.component.css']
})
export class AveneoComponent implements OnInit {

  model: any = {};
  constructor(private businessEntityService: BusinessEntityService) { }

  ngOnInit() {

  }



  getSearchQuery() {
    const temp = this.getDigits(this.model.searchQuery);
    console.log(temp);
    this.businessEntityService.getBusinessEntity(temp);
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
