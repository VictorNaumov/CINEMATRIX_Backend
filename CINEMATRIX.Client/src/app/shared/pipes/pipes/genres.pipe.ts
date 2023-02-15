import { Pipe, PipeTransform } from '@angular/core';
import { GenreFoundIncomingDto } from 'src/app/core/models/genre/genre-found-incoming-dto';
/*
 * Example:
 *   {{ GenreFoundIncomingDto | genres }}
 *   formats to: Horror, Drama, Adventure
*/
@Pipe({name: 'genresPipe'})
export class GenresPipe implements PipeTransform {
  transform(genres: GenreFoundIncomingDto[]): string {
    return genres.map(x => x.name).join(", ");
  }
}
