import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, Subject, throwError } from "rxjs";
import { catchError, tap } from "rxjs/operators";
import { Router } from "@angular/router";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { getUrl } from "src/app/shared/functions/getUrl";
import { AdminValidationDto } from "../models/auth/admin-validation-dto";
import { RegistrationDto } from "../models/auth/admin-registration-dto";
import { ValidationResponseDto } from "../models/auth/validation-response-dto";

@Injectable({ providedIn: 'root' })
export class AuthService {

  public error$: Subject<string> = new Subject<string>();
  public pathBase: string = `${connectionString}/auth/`;

  constructor(
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
  public login(user: AdminValidationDto): Observable<any> {
    return this.http.post<ValidationResponseDto>(`${this.pathBase}login`, user)
      .pipe(
        tap((result: ValidationResponseDto) => this.setTokenAndRole(result)),
        catchError(this.handleError.bind(this)
        )
      );
  }

  public signup(user: RegistrationDto): Observable<any> {
    return this.http.post<ValidationResponseDto>(`${this.pathBase}register`, user)
      .pipe(
        tap((result: ValidationResponseDto) => this.setTokenAndRole(result)),
        catchError(this.handleError.bind(this)
        )
      );
  }

  logout() {
    this.setTokenAndRole(null);
    this.router.navigate(['']);
  }

  isAuthenticated(): boolean {
    return !!this.token;
  }

  private setTokenAndRole(data: ValidationResponseDto) {
    debugger

    if (data) {
      const expiresDate = new Date(new Date().getTime() + 60 * 60 * 1000);
      localStorage.setItem('token', data.token);
      localStorage.setItem('role', data.role);
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
