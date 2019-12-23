import { Injectable, OnDestroy  } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Stadium } from '../models/Stadium';
import { Subject } from 'rxjs';

@Injectable({
    providedIn: 'root'
})

export class StadiumService implements OnDestroy {
    public baseUrl: string = environment.ApiUrl;
    public routeStadium = 'api/stadium';
    public headers = new HttpHeaders();

    unsubscribe = new Subject();
    constructor(private http: HttpClient) {}

    GetAllStadium(httpParams?: any) {
        console.log(this.baseUrl + this.routeStadium);
        return this.http.get<Stadium[]>(this.baseUrl + this.routeStadium,
            {observe: 'response', headers: this.headers, params: httpParams});
    }
    AddStadium(newStadium: Stadium) {
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this.http.post<Stadium>(
            this.baseUrl + this.routeStadium, newStadium, {headers}
        );
    }
    ngOnDestroy() {
        this.unsubscribe.next();
        this.unsubscribe.unsubscribe();
    }
}
