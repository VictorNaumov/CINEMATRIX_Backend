import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ManagementRoutes } from './management-routing';
import { ManagementComponent } from './components/management.component';

@NgModule({
  declarations: [ManagementComponent],
  imports: [
    CommonModule,
    ManagementRoutes
  ]
})
export class ManagementModule { }
