import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Player } from '../models/Player';

@Injectable({
    providedIn: 'root'
})

export class PlayerService {
    public baseUrl: string = environment.ApiUrl;
    public routePlayer = 'api/player';
    public headers = new HttpHeaders();

    constructor(private http: HttpClient) {}

    GetAllPlayers(httpParams?: any) {
        return this.http.get<Player[]>(this.baseUrl + this.routePlayer,
            {observe: 'response', headers: this.headers, params: httpParams});
    }
}
