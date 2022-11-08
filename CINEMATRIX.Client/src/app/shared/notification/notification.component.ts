import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Notification, NotificationManager } from 'src/app/core/services/notification-manager';

@Component({
  selector: 'app-notification',
  templateUrl: './notification.component.html',
  styleUrls: ['./notification.component.scss']
})
export class NotificationComponent implements OnInit, OnDestroy {
  public notices: Notification[] = [];
  aSub: Subscription;
  delay = 5000;

  constructor(private notificationManager: NotificationManager) { }

  ngOnInit(): void {
    this.aSub = this.notificationManager.notification$.subscribe((notice: Notification) => {
      this.notices.push(notice);

      const timeout = setTimeout(() => {
        clearTimeout(timeout);
        this.notices.splice(this.notices.indexOf(notice), 1);
      }, this.delay)
    })
  }

  ngOnDestroy(): void {
    if (this.aSub) this.aSub.unsubscribe();
  }
}
