/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { BusinessEntityService } from './businessEntity.service';

describe('Service: BusinessEntity', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BusinessEntityService]
    });
  });

  it('should ...', inject([BusinessEntityService], (service: BusinessEntityService) => {
    expect(service).toBeTruthy();
  }));
});
