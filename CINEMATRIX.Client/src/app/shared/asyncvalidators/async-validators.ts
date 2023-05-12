import { AbstractControl, AsyncValidatorFn, ValidationErrors } from "@angular/forms";
import { map, Observable } from "rxjs";
import { AuthService } from "src/app/core/account/auth-service";

export function checkEmailInSystemValidator(authService: AuthService): AsyncValidatorFn {
  return (control: AbstractControl): Observable<ValidationErrors> => {
    return authService
      .checkExistEmail(control.value)
      .pipe(map((result: any) => (result ? { invalidEmail: true } : null)));
  };
}

export function checkUsernameInSystemValidator(authService: AuthService): AsyncValidatorFn {
  return (control: AbstractControl): Observable<ValidationErrors> => {
    return authService
      .checkExistUsername(control.value)
      .pipe(map((result: any) => (result ? { invalidEmail: true } : null)));
  };
}
