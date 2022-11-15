import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NotificationComponent } from './shared/notification/notification.component';
import { HeaderModule } from './content/layout/header/header.module';
import { AuthService } from './core/account/auth-service';
import { AuthGuard } from './core/guards/auth.guard';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthInterseptor } from './core/account/auth-interseptor';
import { MaterialModule } from './shared/material/material.module';
import { BuyTicketDialog } from './content/dialogs/buy-ticket-dialog/buy-ticket-dialog.component';
import { HallSeatsComponent } from './content/dialogs/buy-ticket-dialog/hall-seats/hall-seats.component';

@NgModule({
  declarations: [
    AppComponent,
    NotificationComponent,
    BuyTicketDialog,
    HallSeatsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HeaderModule,
    MaterialModule,
    HttpClientModule,
  ],
  providers: [
    AuthGuard,
    AuthService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterseptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
