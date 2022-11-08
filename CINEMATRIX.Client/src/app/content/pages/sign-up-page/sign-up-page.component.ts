import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { AuthService } from 'src/app/core/account/auth-service';
import { AdminRegistrationDto } from 'src/app/core/models/auth/admin-registration-dto';
import { NotificationManager } from 'src/app/core/services/notification-manager';

@Component({
  selector: 'app-sign-up-page',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.scss']
})
export class SignUpPageComponent implements OnInit {
  public form: FormGroup = new FormGroup({});
  public submitted: boolean = false;
  public message: string = '';

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

    this.form = new FormGroup({
      login: new FormControl('', [Validators.required, Validators.minLength(4)]),
      email: new FormControl('', [Validators.required, Validators.email]),
      confirmpassword: new FormControl('', [Validators.required, Validators.minLength(4)]),
      password: new FormControl('', [Validators.required, Validators.minLength(6)]),
      secretKey: new FormControl('', [Validators.required, Validators.minLength(6)])
    });
  }

  public submit(): void {
    if (this.form.invalid || this.form.value.password != this.form.value.confirmpassword){
      return;
    }
    this.notificationManager.ErrorNotice("suck")

    this.submitted = true;

    const user: AdminRegistrationDto = {
      userName: this.form.value.login,
      password: this.form.value.password,
      email: this.form.value.email,
    };

    this.authService.signup(user, null).subscribe(() => {
      this.form.reset();
      this.router.navigate(['/']);
      this.submitted = false;
    }, () => {
      this.submitted = false;
    });
  }
}
