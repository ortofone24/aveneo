import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class BusinessEntityService {

baseUrl = 'https://localhost:44335/api/BusinessEntity/';
businessEntity: any;


constructor(private http: HttpClient) { }

getBusinessEntity(searchQuery: string) {
  this.http.get(this.baseUrl + searchQuery).subscribe(response => {
    this.businessEntity = response;
  }, error => {
    console.log(error);
  });
}

getBusinessEntityTest(searchQuery: string) {
  this.http.get(this.baseUrl + searchQuery).pipe(map((response: any) => {
    const test = response;
    return test;
  }));
}
}
