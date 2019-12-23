import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import { Player } from '../models/Player';
import { PlayerService } from '../services/PlayerService';
import { TeamService } from '../services/TeamService';
import { Team } from '../models/Team';

declare var $: any;

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.sass']
})
export class PlayersComponent implements OnInit {
  name: string;
  teamId;
  bornDate: Date;
  contractDate: Date;
  players: Player[];
  teams: Team[];
  displayedColumns: string[] = ['Id', 'TeamId', 'Name', 'Born', 'Contract'];
  dataSource = new MatTableDataSource(this.players);
  constructor(private playerService: PlayerService, private teamService: TeamService) { }

  First(date) {
    this.bornDate = date;
  }
  Second(date) {
    this.contractDate = date;
  }
  PickTeam($event) {
    this.teamId = $event;
  }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  Send() {
    const player: Player = {
      id: 0,
      fullName: this.name,
      teamId: this.teamId,
      bornDate: this.bornDate,
      contractDate: this.contractDate
    };
    this.playerService.AddPlayer(player).subscribe(x => console.log(x));
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
    this.playerService.GetAllPlayers().subscribe(x => {this.players = x.body; this.dataSource = new MatTableDataSource(this.players); });
    this.teamService.GetAllTeams().subscribe(x => {this.teams = x.body; console.log(this.teams); });
  }
}
