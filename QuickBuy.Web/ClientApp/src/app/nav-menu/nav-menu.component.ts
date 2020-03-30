import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  template: './nav-menu.component.html',
  styles: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
