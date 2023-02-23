import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, Subject, throwError } from "rxjs";
import { catchError, tap } from "rxjs/operators";
import { Router } from "@angular/router";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { SignInDto } from "../models/auth/sign-in-dto";
import { SignUpDto } from "../models/auth/sign-up-dto";
import { ValidationResponseDto } from "../models/auth/validation-response-dto";
import { UserFoundIncomingDto } from "../models/auth/user-found-incoming-dto";
import { MatDialog } from "@angular/material";
import { SignInComponent } from "src/app/modules/auth/components/sign-in/sign-in.component";
import { SignUpComponent } from "src/app/modules/auth/components/sign-up/sign-up.component";

@Injectable({ providedIn: 'root' })
export class AuthService {

  public error$: Subject<string> = new Subject<string>();
  public pathBase: string = `${connectionString}/auth/`;

  constructor(
    private dialog: MatDialog,
    private http: HttpClient,
    private router: Router) { }

  get token(): string | null {
    const expiresDate = new Date(String(localStorage.getItem('token-exp')));
    if (new Date() > expiresDate) {
      this.logout();
      return null;
    }
    return localStorage.getItem('token');
  }

  get profileId(): string | null {
    const expiresDate = new Date(String(localStorage.getItem('token-exp')));
    if (new Date() > expiresDate) {
      this.logout();
      return null;
    }
    return localStorage.getItem('profile-id');
  }

  public login(user: SignInDto): Observable<any> {
    return this.http.post<ValidationResponseDto>(`${this.pathBase}login`, user)
      .pipe(
        tap((result: ValidationResponseDto) => this.setAccountData(result)),
        catchError(this.handleError.bind(this)
        )
      );
  }

  public whoami(): Observable<any> {
    return this.http.get<UserFoundIncomingDto>(`${this.pathBase}whoami`)
  }

  public signUp(user: SignUpDto): Observable<any> {
    return this.http.post<ValidationResponseDto>(`${this.pathBase}register`, user)
      .pipe(
        tap((result: ValidationResponseDto) => this.setAccountData(result)),
        catchError(this.handleError.bind(this)
        )
      );
  }

  public openSignInDialog(){
    this.dialog.closeAll();
    this.dialog.open(SignInComponent);
  }

  public openSignUpDialog(){
    this.dialog.closeAll();
    this.dialog.open(SignUpComponent);
  }

  logout() {
    this.setAccountData(null);
    this.router.navigate(['']);
  }

  isAuthenticated(): boolean {
    return !!this.token;
  }

  private setAccountData(response: ValidationResponseDto) {
    if (response) {
      const expiresDate = new Date(new Date().getTime() + 60 * 60 * 1000);
      localStorage.setItem('token', response.token);
      localStorage.setItem('role', response.role);
      localStorage.setItem('profile-id', response.profileId.toString());
      localStorage.setItem('token-exp', expiresDate.toString());
    } else {
      localStorage.clear();
    }
  }

  private handleError(error: HttpErrorResponse): Observable<never> {
    const { message } = error.error;

    switch (message) {
      case 'INVALID_EMAIL':
        this.error$.next('Wrong email');
        break;
      case 'INVALID_PASSWORD':
        this.error$.next('Wrong password');
        break;
      case 'EMAIL_NOT_FOUND':
        this.error$.next('Nonexistent email');
        break;
    }

    return throwError(error);
  }
}
