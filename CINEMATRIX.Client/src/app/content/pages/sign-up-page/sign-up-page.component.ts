import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { AuthService } from 'src/app/core/account/auth-service';
import { RegistrationDto as RegistrationDto } from 'src/app/core/models/auth/admin-registration-dto';
import { NotificationManager } from 'src/app/core/services/notification-manager';

@Component({
  selector: 'app-sign-up-page',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.scss']
})
export class SignUpPageComponent implements OnInit {
  public submitted: boolean = false;
  public message: string = '';

  public userName: string;
  public email: string;
  public confirmPassword: string;
  public password: string;

  constructor(public authService: AuthService,
    private router: Router,
    private route: ActivatedRoute,
    private notificationManager: NotificationManager) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe((params: Params) => {
      if (params.loginAgain)
        this.message = 'Please, enter data';
      else if (params.authFailed)
        this.message = 'Session ended. Enter data again.';
    });
  }

  public onSubmit(): void {

    debugger

    if (this.password != this.confirmPassword) {
      return;
    }

    this.submitted = true;

    let user: RegistrationDto = {
      userName: this.userName,
      password: this.password,
      email: this.email,
      roleId: 3,
    };


    this.authService.signup(user).subscribe(() => {
      this.router.navigate(['/']);
      this.submitted = false;
    }, () => {
      this.submitted = false;
    });
  }
}
