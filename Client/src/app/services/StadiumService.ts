import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Stadium } from '../models/Stadium';

@Injectable({
    providedIn: 'root'
})

export class StadiumService {
    public baseUrl: string = environment.ApiUrl;
    public routeStadium = 'api/stadium';
    public headers = new HttpHeaders();

    constructor(private http: HttpClient) {}

    GetAllStadium(httpParams?: any) {
        return this.http.get<Stadium[]>(this.baseUrl + this.routeStadium,
            {observe: 'response', headers: this.headers, params: httpParams});
    }
}
