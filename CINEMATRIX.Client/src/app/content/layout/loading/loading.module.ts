import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoadingComponent } from './loading.component';
import { MaterialModule } from 'src/app/shared/material/material.module';

@NgModule({
  declarations: [
    LoadingComponent
  ],
  imports: [
    CommonModule,
    MaterialModule
  ],
  exports: [
    LoadingComponent
  ],
  providers: []
})
export class LoadingModule { }
