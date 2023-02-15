import { NgModule } from '@angular/core';
import { GenresPipe } from './pipes/genres.pipe';
import { RuntimePipe } from './pipes/runtime.pipe';

@NgModule({
  declarations: [
    GenresPipe,
    RuntimePipe
  ],
  exports: [
    GenresPipe,
    RuntimePipe
  ]
})
export class PipesModule { }
