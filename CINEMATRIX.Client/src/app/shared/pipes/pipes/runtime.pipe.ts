import { Pipe, PipeTransform } from '@angular/core';
/*
 * Example:
 *   {{ RuntimePipe | runtimePipe }}
 *   formats to: 1:32
*/
@Pipe({name: 'runtimePipe'})
export class RuntimePipe implements PipeTransform {
  transform(runtime: number): string {
    let hours = Math.floor(runtime / 60)
    let minutes = runtime % 60;

    return `${hours < 10 ? '0' + hours : hours}:${minutes < 10 ? '0' + minutes : minutes}`
  }
}
