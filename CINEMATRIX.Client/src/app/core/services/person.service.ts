import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { PersonFoundIncomingDto } from "../models/person/person-found-incoming-dto";
import { PersonSearchIncomingDto } from "../models/person/person-search-incoming-dto";
import { PersonSearchOutgoingDto } from "../models/person/person-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class PersonService {
  public pathBase: string = `${connectionString}/person`;

  constructor(private http: HttpClient) { }

  public GetPopularPeople(searchParameters: PersonSearchOutgoingDto): Observable<PersonSearchIncomingDto> {
    return this.http.post<PersonSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
  }

  public GetPersonById(personId: number): Observable<PersonFoundIncomingDto> {
      return this.http.get<PersonFoundIncomingDto>(`${this.pathBase}/${personId}`);
  }
}
