import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import { Team } from '../models/Team';
import { TeamService } from '../services/TeamService';
import { Stadium } from '../models/Stadium';
import { StadiumService } from '../services/StadiumService';
import { TournamentService } from '../services/TournamentService';
import { Tournament } from '../models/Tournament';
import { Match } from '../models/Match';
import { MatchService } from '../services/MatchService';

declare var $: any;

@Component({
  selector: 'app-matches',
  templateUrl: './matches.component.html',
  styleUrls: ['./matches.component.sass']
})
export class MatchesComponent implements OnInit {

  tournamentId: number;
  teamId: number;
  teamSecId: number;
  stadiumId: number;
  start: Date;
  end: Date;
  tournaments: Tournament[];
  teams: Team[];
  stadiums: Stadium[];
  matches: Match[];
  displayedColumns: string[] = ['Id', 'TournamentId', 'TeamId', 'TeamId2', 'StadiumId', 'Start', 'End'];
  dataSource = new MatTableDataSource(this.matches);

  constructor(private teamService: TeamService, private stadiumService: StadiumService,
              private tournamentService: TournamentService, private matchService: MatchService) { }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  PickTournament($event) {
    this.tournamentId = $event;
  }
  PickTeam($event) {
    this.teamId = $event;
  }
  PickTeamSec($event) {
    console.log($event);
    this.teamSecId = $event;
  }
  PickStadium($event) {
    this.stadiumId = $event;
  }
  First(date) {
    this.start = date;
  }
  Second(date) {
    this.end = date;
  }
  Send() {
    const match: Match = {
      id: 0,
      tournamentId: this.tournamentId,
      teamId: this.teamId,
      team2Id: this.teamSecId,
      stadiumId: this.stadiumId,
      start: this.start,
      end: this.end
    };
    console.log(this.teamSecId);
    this.matchService.AddMatch(match).subscribe(x => console.log(x));
  }
  aaa() {
    console.log(this.stadiumId);
  }
  ngOnInit() {
    $('#example1').calendar({
      popupOptions: {
        observeChanges: false
      },
      onChange: (date, text) => this.First(date),
      isDisabled : (date, mode) => false,
    });
    $('#example2').calendar({
      popupOptions: {
        observeChanges: false
      },
      onChange: (date, text) => this.Second(date),
      isDisabled : (date, mode) => false,
    });
    this.teamService.GetAllTeams().subscribe(x => {this.teams = x.body; console.log(this.teams); });
    this.stadiumService.GetAllStadium().subscribe(x => {this.stadiums = x.body; console.log(this.stadiums); });
    this.tournamentService.GetAllTournament().subscribe(x => {this.tournaments = x.body; console.log(this.tournaments); });
    this.matchService.GetAllMatch().subscribe(x => {this.matches = x.body; console.log(this.matches);
                                                    this.dataSource = new MatTableDataSource(this.matches); });
  }

}
