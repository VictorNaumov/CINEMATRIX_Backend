import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { ProfileDto } from "../models/profile/profile-dto";

@Injectable({ providedIn: 'root' })
export class ProfileService {
  public pathBase: string = `${connectionString}/Profile`;

  constructor(private http: HttpClient) {}

  public CreateProfile(profile: ProfileDto): Observable<number> {
    return this.http.post<number>(this.pathBase, profile);
  }

  public DeleteProfile(profileId: number): Observable<any> {
    return this.http.delete<any>(`${this.pathBase}/${profileId}`);
  }

  public UpdateProfile(profileId: number, profile: ProfileDto): Observable<ProfileDto> {
    return this.http.put<ProfileDto>(`${this.pathBase}/${profileId}`, profile);
  }

  public GetProfileById(profileId: number): Observable<ProfileDto> {
    return this.http.get<ProfileDto>(`${this.pathBase}/${profileId}`);
  }
}
