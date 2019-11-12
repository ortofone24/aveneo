import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class BusinessEntityService {

constructor(private http: HttpClient) { }

private baseUrl = 'https://localhost:44335/api/BusinessEntity/';

private baseUrl2 = 'http://ortofone-001-site1.htempurl.com/api/BusinessEntity/';

getBusinessEntity(searchQuery): Observable<any> {
  return this.http.get(this.baseUrl2 + searchQuery)
  .pipe(
    catchError(err => {
      return throwError(err);
    })
  );
}

}

