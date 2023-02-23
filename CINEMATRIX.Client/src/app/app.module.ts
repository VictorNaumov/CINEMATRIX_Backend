import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BuyTicketDialog } from './content/dialogs/buy-ticket-dialog/buy-ticket-dialog.component';
import { HallSeatsComponent } from './content/dialogs/buy-ticket-dialog/hall-seats/hall-seats.component';
import { HeaderModule } from './content/layout/header/header.module';
import { AuthInterseptor } from './core/account/auth-interseptor';
import { AuthService } from './core/account/auth-service';
import { AuthGuard } from './core/guards/auth.guard';
import { MaterialModule } from './shared/material/material.module';
import { NotificationComponent } from './shared/notification/notification.component';

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
    MaterialModule,
    HeaderModule,
    HttpClientModule
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
