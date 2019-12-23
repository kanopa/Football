import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Match } from '../models/Match';

@Injectable({
    providedIn: 'root'
})

export class MatchService {
    public baseUrl: string = environment.ApiUrl;
    public routeMatch = 'api/match';
    public headers = new HttpHeaders();

    constructor(private http: HttpClient) {}

    GetAllMatch(httpParams?: any) {
        return this.http.get<Match[]>(this.baseUrl + this.routeMatch,
            {observe: 'response', headers: this.headers, params: httpParams});
    }
    AddMatch(newMatch: Match) {
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this.http.post<Match>(
            this.baseUrl + this.routeMatch, newMatch, {headers}
        );
    }
}
