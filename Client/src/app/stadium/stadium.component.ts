import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import { Stadium } from '../models/Stadium';
import { StadiumService } from '../services/StadiumService';

declare var $: any;

@Component({
  selector: 'app-stadium',
  templateUrl: './stadium.component.html',
  styleUrls: ['./stadium.component.sass']
})
export class StadiumComponent implements OnInit {
  name: string;
  city: string;
  capacity: number;
  constructor(private stadiumService: StadiumService) { }
  stadiums: Stadium[];
  displayedColumns: string[] = ['Id', 'Name', 'City', 'Capacity'];
  dataSource = new MatTableDataSource(this.stadiums);

  Send() {
    console.log(this.name + this.city + this.capacity);
    const stadium: Stadium = {id: 0, name: this.name, city: this.city, capacity: this.capacity};
    console.log(this.capacity);
    this.stadiumService.AddStadium(stadium).subscribe(x => { });
  }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  ngOnInit() {
    this.stadiumService.GetAllStadium().subscribe(x => {this.stadiums = x.body; this.dataSource = new MatTableDataSource(this.stadiums); });
  }
}
