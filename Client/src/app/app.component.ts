import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent {
  title = 'Client';
  constructor(private router: Router) {}
  isCurrentRouteRight(route: string) {
    return route && this.router.url.search(route) !== -1;
  }
}
