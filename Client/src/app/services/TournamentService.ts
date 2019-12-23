import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Tournament } from '../models/Tournament';

@Injectable({
    providedIn: 'root'
})

export class TournamentService {
    public baseUrl: string = environment.ApiUrl;
    public routeTournament = 'api/tournament';
    public headers = new HttpHeaders();

    constructor(private http: HttpClient) {}

    GetAllTournament(httpParams?: any) {
        console.log(this.baseUrl + this.routeTournament);
        return this.http.get<Tournament[]>(this.baseUrl + this.routeTournament,
            {observe: 'response', headers: this.headers, params: httpParams});
    }
}
