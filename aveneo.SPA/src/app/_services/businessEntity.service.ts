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

getBusinessEntity(searchQuery): Observable<any> {
  return this.http.get(this.baseUrl + searchQuery)
  .pipe(
    catchError(err => {
      return throwError(err);
    })
  );
}

}

