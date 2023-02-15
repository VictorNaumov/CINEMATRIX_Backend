import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { AuthService } from 'src/app/core/account/auth-service';
import { SignInDto } from 'src/app/core/models/auth/user-validation-dto';

@Component({
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.scss']
})
export class SignInComponent implements OnInit {
  public hide = true;

  public authForm: FormGroup = new FormGroup({
    email: new FormControl(
      '',
      Validators.compose([Validators.required, Validators.pattern('^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')])
    ),
    password: new FormControl(
      '',
      Validators.compose([Validators.required, Validators.minLength(6), Validators.maxLength(15)])
    )
  });

  ngOnInit() {}

  public submitted = false;
  public message: string;

  constructor(
    public authService: AuthService,
    public dialog: MatDialog,
    public router: Router,
    public route: ActivatedRoute) { }

  submit() {
    const user: SignInDto = {
      email: this.authForm['email'],
      password: this.authForm['password']
    }

    this.authService.login(user).subscribe(() => {
    this.router.navigate(['/']);
    this.submitted = false;
  }, () => {
    this.submitted = false;
  });
  }
}
