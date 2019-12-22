import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';

export interface PeriodicElement {
  Id: number;
  FullName: string;
  Born: string;
  Contract: string;
}

export interface Team {
  Name: string;
  City: string;
  CountPlayers: number;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {Id: 1, FullName: 'Hydrogen', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 2, FullName: 'Helium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 3, FullName: 'Lithium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 4, FullName: 'Beryllium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 5, FullName: 'Boron', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 1, FullName: 'Hydrogen', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 2, FullName: 'Helium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 3, FullName: 'Lithium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 4, FullName: 'Beryllium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 5, FullName: 'Boron', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 1, FullName: 'Hydrogen', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 2, FullName: 'Helium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 3, FullName: 'Lithium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 4, FullName: 'Beryllium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 5, FullName: 'Boron', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 4, FullName: 'Beryllium', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()},
  {Id: 5, FullName: 'Boron', Born: new Date(2000, 12, 10).toLocaleDateString(), Contract: new Date(2019, 12, 10).toLocaleDateString()}
];

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.sass']
})
export class PlayersComponent implements OnInit {
  displayedColumns: string[] = ['Id', 'FullName', 'Born', 'Contract'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);

  teams: Team[] = [
    {Name: 'Team-0', City: 'Steak', CountPlayers: 40000},
    {Name: 'Team-1', City: 'Pizza', CountPlayers: 40000},
    {Name: 'Team-2', City: 'Tacos', CountPlayers: 40000}
  ];

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  constructor() { }

  ngOnInit() {
  }
}
