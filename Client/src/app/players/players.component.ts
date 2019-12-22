import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import { Player } from '../models/Player';
import { PlayerService } from '../services/PlayerService';
import { TeamService } from '../services/TeamService';
import { Team } from '../models/Team';

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.sass']
})
export class PlayersComponent implements OnInit {
  players: Player[];
  teams: Team[];
  displayedColumns: string[] = ['Id', 'TeamId', 'Name', 'Born', 'Contract'];
  dataSource = new MatTableDataSource(this.players);
  constructor(private playerService: PlayerService, private teamService: TeamService) { }


  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  ngOnInit() {
    this.playerService.GetAllPlayers().subscribe(x => {this.players = x.body; this.dataSource = new MatTableDataSource(this.players); });
    this.teamService.GetAllTeams().subscribe(x => {this.teams = x.body; console.log(this.teams); });
  }
}
