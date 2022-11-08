import { Component } from '@angular/core';
import { NotificationManager } from './core/services/notification-manager';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'CINEMATRIX.Client';

  constructor(
    public notificationService: NotificationManager) { }

  ngOnInit(): void { }

  addNotification() {
    console.log("aa")
    this.notificationService.textNotice("Hello");
  }
}
