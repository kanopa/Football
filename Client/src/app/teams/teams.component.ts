import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';


declare var $: any;

export interface Team {
  Name: string;
  City: string;
  CountPlayers: number;
}


@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.sass']
})
export class TeamsComponent implements OnInit {
  check: Date;
  constructor() { }
  teams: Team[] = [
    {Name: 'Team-0', City: 'Steak', CountPlayers: 40000},
    {Name: 'Team-1', City: 'Pizza', CountPlayers: 40000},
    {Name: 'Team-2', City: 'Tacos', CountPlayers: 40000}
  ];
  displayedColumns: string[] = ['Name', 'City', 'CountPlayers'];
  dataSource = new MatTableDataSource(this.teams);

  aaaa() {
    console.log(this.check);
  }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  ngOnInit() {
      $('#example1').calendar();
      $('#example2').calendar();
  }

}
