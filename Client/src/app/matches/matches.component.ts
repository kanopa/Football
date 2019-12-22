import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';

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
export interface Team {
  Name: string;
  City: string;
  CountPlayers: number;
}

@Component({
  selector: 'app-matches',
  templateUrl: './matches.component.html',
  styleUrls: ['./matches.component.sass']
})
export class MatchesComponent implements OnInit {

  teams: Team[] = [
    {Name: 'Team-0', City: 'Steak', CountPlayers: 40000},
    {Name: 'Team-1', City: 'Pizza', CountPlayers: 40000},
    {Name: 'Team-2', City: 'Tacos', CountPlayers: 40000}
  ];
  matches: Match[] = [
    { Id: 1, TournamentId: 1, TeamId: 1, TeamId2: 2, StadiumId: 2, Start: new Date(2019, 22, 14).toLocaleDateString(),
      End: new Date(2019, 22, 14).toLocaleDateString()},
    { Id: 2, TournamentId: 1, TeamId: 3, TeamId2: 4, StadiumId: 1, Start: new Date(2019, 22, 14).toLocaleDateString(),
      End: new Date(2019, 22, 14).toLocaleDateString()},
  ];
  displayedColumns: string[] = ['Id', 'TournamentId', 'TeamId', 'TeamId2', 'StadiumId', 'Start', 'End'];
  dataSource = new MatTableDataSource(this.matches);
  constructor() { }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  ngOnInit() {
    $('#example1').calendar();
    $('#example2').calendar();
  }

}
