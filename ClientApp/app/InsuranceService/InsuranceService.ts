import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()

export class InsuranceService {

    constructor(private http: Http) {

        this.http = http;
    }

    getCompany() {
        return this.http.get('http://localhost:5000/api/company')
            .map(res => res.json());
    }

    getfeatures() {
        return this.http.get('http://localhost:5000/api/features')
            .map(res => res.json());
    }
}