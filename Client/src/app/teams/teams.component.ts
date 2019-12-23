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
  name: string;
  city: string;
  count: number;
  constructor(private teamService: TeamService) { }
  teams: Team[];
  displayedColumns: string[] = ['Id', 'Name', 'City', 'CountPlayers'];
  dataSource = new MatTableDataSource(this.teams);

  Send() {
    console.log(this.name + this.city + this.count);
    const team: Team = {id: 0, name: this.name, city: this.city, count: this.count};
    this.teamService.AddTeam(team).subscribe(x => { });
  }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  ngOnInit() {
    this.teamService.GetAllTeams().subscribe(x => {this.teams = x.body; this.dataSource = new MatTableDataSource(this.teams); });
  }

}
