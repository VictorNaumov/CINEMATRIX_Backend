import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest, HttpEvent } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { MatSnackBar } from "@angular/material";
import { Router } from "@angular/router";
import { Observable, throwError } from "rxjs";
import { catchError } from "rxjs/operators";
import { AuthService } from "./auth-service";

@Injectable()
export class AuthInterseptor implements HttpInterceptor {
  constructor(
    private snackBar: MatSnackBar,
    private authService: AuthService,
    private router: Router) {
  }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if (this.authService.isAuthenticated()) {
      req = req.clone({
        headers: req.headers.set('Authorization', `Bearer ${this.authService.token}`)
      });
    }
    return next.handle(req).pipe(
      catchError((error: HttpErrorResponse) => {
        this.snackBar.open(error.message, "Close")
        console.log(error);

        switch (error.status) {
          case 0: {
            this.snackBar.open("Server is not available!", "Close")
          } break;
          case 401: {
            console.log('Unauthorized error');
            this.authService.logout();
            this.router.navigate(['login'], {
              queryParams: {
                authFailed: true
              }
            });
          } break;
          case 404: {
          } break;
        }

        return throwError(error);
      }));
  }
}
