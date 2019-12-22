import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import { Team } from '../models/Team';
import { TeamService } from '../services/TeamService';
import { Stadium } from '../models/Stadium';
import { StadiumService } from '../services/StadiumService';

declare var $: any;

export interface Match {
  Id: number;
  TournamentId: number;
  TeamId: number;
  TeamId2: number;
  StadiumId: number;
  Start: string;
  End: string;
}

@Component({
  selector: 'app-matches',
  templateUrl: './matches.component.html',
  styleUrls: ['./matches.component.sass']
})
export class MatchesComponent implements OnInit {

  teams: Team[];
  stadiums: Stadium[];
  matches: Match[];
  displayedColumns: string[] = ['Id', 'TournamentId', 'TeamId', 'TeamId2', 'StadiumId', 'Start', 'End'];
  dataSource = new MatTableDataSource(this.matches);
  constructor(private teamService: TeamService, private stadiumService: StadiumService) { }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  ngOnInit() {
    $('#example1').calendar();
    $('#example2').calendar();
    this.teamService.GetAllTeams().subscribe(x => {this.teams = x.body; console.log(this.teams); });
    this.stadiumService.GetAllStadium().subscribe(x => {this.stadiums = x.body; console.log(this.stadiums); });
  }

}
