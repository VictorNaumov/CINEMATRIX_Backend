import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { FoodDto } from "../models/food/food-dto";
import { FoodSearchIncomingDto } from "../models/food/food-search-incoming-dto";
import { FoodSearchOutgoingDto } from "../models/food/food-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class FoodService {
  public pathBase: string = `${connectionString}/food`;

  constructor(private http: HttpClient) { }

  public SearchFood(searchParameters: FoodSearchOutgoingDto): Observable<FoodSearchIncomingDto> {
    return this.http.post<FoodSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
  }

  public CreateFood(food: FoodDto): Observable<number> {
    return this.http.post<number>(`${this.pathBase}`, food);
  }

  public DeleteFood(foodId: number): Observable<any> {
    return this.http.delete<any>(`${this.pathBase}/${foodId}`);
  }

  public UpdateFood(foodId: number, food: FoodDto): Observable<FoodDto> {
    return this.http.put<FoodDto>(`${this.pathBase}/${foodId}`, food);
  }

  public GetFoodById(id: number): Observable<FoodDto> {
    return this.http.get<FoodDto>(`${this.pathBase}/${id}`);
  }
}
