import { Component, OnInit } from "@angular/core";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { MatDialog } from "@angular/material";
import { ActivatedRoute, Router } from "@angular/router";
import { AuthService } from "src/app/core/account/auth-service";
import { RoleEnum } from "src/app/core/enums/enums";
import { SignInDto } from "src/app/core/models/auth/sign-in-dto";
import { SignUpDto } from "src/app/core/models/auth/sign-up-dto";
import { checkEmailInSystemValidator } from "src/app/shared/asyncvalidators/async-validators";

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.scss']
})
export class SignUpComponent implements OnInit {
  public hide = true;
  public submitted: boolean = false;
  public message: string = '';

  public signUpForm: FormGroup = new FormGroup({
    username: new FormControl(
      '',
      Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(20)])
    ),
    email: new FormControl(
      '',
      {
        validators: [Validators.required, Validators.pattern('^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')],
        asyncValidators: [checkEmailInSystemValidator(this.authService)]
      }
    ),
    password: new FormControl(
      '',
      Validators.compose([Validators.required, Validators.minLength(4), Validators.maxLength(15)])
    ),
    confirmPassword: new FormControl(
      '',
      Validators.compose([Validators.required, Validators.minLength(4), Validators.maxLength(15)])
    )
  });

  ngOnInit() { }

  constructor(
    public dialog: MatDialog,
    public authService: AuthService,
    public router: Router,
    public route: ActivatedRoute) { }

  submit() {
    if (this.signUpForm.value['password'] != this.signUpForm.value['confirmPassword']) {
      return;
    }

    this.submitted = true;

    const signUpDto: SignUpDto = {
      email: this.signUpForm.value['email'],
      username: this.signUpForm.value['username'],
      password: this.signUpForm.value['password'],
      roleId: RoleEnum.User
    }

    this.authService.signUp(signUpDto).subscribe(() => {
      this.submitted = false;
      this.dialog.closeAll();
    }, () => {
      this.submitted = false;
    });
  }
}
