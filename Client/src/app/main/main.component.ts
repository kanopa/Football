import { Component, OnInit } from '@angular/core';
import { Team } from '../models/Team';
import { TeamService } from '../services/TeamService';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.sass']
})
export class MainComponent implements OnInit {
  teams: Team[];
  constructor(private teamService: TeamService) { }

  ngOnInit() {
    this.teamService.GetAllTeams().subscribe(x => {this.teams = x.body; console.log(this.teams); });
  }

}
