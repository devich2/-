import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import { UnitTypeAggr } from '../../models/unit-type.model';
import { Injectable } from '@angular/core';
import { Classification, ClassificationAddResponse, ClassificationCreateModel } from '../../models/classification.model';
  
  @Injectable({providedIn: 'root'})
  export class ClassificationApiService {
  
    typeHier:UnitTypeAggr;
    constructor(protected httpClient: HttpClient) {
        this.getTypesHier().subscribe((data: UnitTypeAggr) => {this.typeHier = data;});
    }
  
    getTypesHier(): Observable<UnitTypeAggr> {
      return this.httpClient.get<UnitTypeAggr>('/api/unit_types');
    }
  
    createClassification(classification: ClassificationCreateModel): Observable<ClassificationAddResponse> {
      return this.httpClient.post<ClassificationAddResponse>('/api/classification', classification);
    }

    getClassificationsForParent(unitId:number = null): Observable<Classification[]> {
      return this.httpClient.get<Classification[]>(`/api/classification/${unitId}`);
    }
  
  }
  