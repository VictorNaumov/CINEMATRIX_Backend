import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { AuthService } from 'src/app/core/account/auth-service';
import { SignInDto } from 'src/app/core/models/auth/sign-in-dto';

@Component({
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.scss']
})
export class SignInComponent implements OnInit {
  public hide = true;

  public signInForm: FormGroup = new FormGroup({
    email: new FormControl(
      '',
      Validators.compose([Validators.required, Validators.pattern('^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')])
    ),
    password: new FormControl(
      '',
      Validators.compose([Validators.required, Validators.minLength(4), Validators.maxLength(15)])
    )
  });

  ngOnInit() { }

  public submitted = false;
  public message: string;

  constructor(
    public dialog: MatDialog,
    public authService: AuthService,
    public router: Router,
    public route: ActivatedRoute) { }

  submit() {
    const signInDto: SignInDto = {
      email: this.signInForm.value['email'],
      password: this.signInForm.value['password']
    }

    this.authService.login(signInDto).subscribe(() => {
      this.submitted = false;
      this.dialog.closeAll();
    }, () => {
      this.submitted = false;
    });
  }
}
