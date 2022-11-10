import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header.component';
import { AppRoutingModule } from 'src/app/app-routing.module';
import { MaterialModule } from 'src/app/shared/material/material.module';

@NgModule({
  declarations: [
    HeaderComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule,
    MaterialModule
  ],
  exports: [
    HeaderComponent
  ],
})
export class HeaderModule { }
