import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import { Team } from '../models/Team';
import { TeamService } from '../services/TeamService';

declare var $: any;

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.sass']
})
export class TeamsComponent implements OnInit {
  check: Date;
  constructor(private teamService: TeamService) { }
  teams: Team[];
  displayedColumns: string[] = ['Id', 'Name', 'City', 'CountPlayers'];
  dataSource = new MatTableDataSource(this.teams);

  aaaa() {
    console.log(this.check);
  }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  ngOnInit() {
    this.teamService.GetAllTeams().subscribe(x => {this.teams = x.body; this.dataSource = new MatTableDataSource(this.teams); });
  }

}
