import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/core/account/auth-service';
import { NotificationManager } from 'src/app/core/services/notification-manager';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  title = "Cinematrix"

  constructor(
    public authService: AuthService,
    public notificationService: NotificationManager) { }

  ngOnInit(): void { }

  logout() {
    this.authService.logout();
  }
}
