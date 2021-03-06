import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Team } from '../models/Team';

@Injectable({
    providedIn: 'root'
})

export class TeamService {
    public baseUrl: string = environment.ApiUrl;
    public routeTeam = 'api/team';
    public headers = new HttpHeaders();

    constructor(private http: HttpClient) {}

    GetAllTeams(httpParams?: any) {
        console.log(this.baseUrl + this.routeTeam);
        return this.http.get<Team[]>(this.baseUrl + this.routeTeam,
            {observe: 'response', headers: this.headers, params: httpParams});
    }
    AddTeam(newPlayer: Team) {
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this.http.post<Team>(
            this.baseUrl + this.routeTeam, newPlayer, {headers}
        );
    }
    UpdateTeam(id: number, httpParams?: any) {
        return this.http.put<Team[]>(this.baseUrl + this.routeTeam + `/${id}`,
            {observe: 'response', headers: this.headers, params: httpParams});
    }
}
