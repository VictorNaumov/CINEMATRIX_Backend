import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { connectionString } from "src/app/shared/constants/connection.constants";
import { FAQDto } from "../models/faq/faq-dto";
import { FAQSearchIncomingDto } from "../models/faq/faq-search-incoming-dto";
import { FAQSearchOutgoingDto } from "../models/faq/faq-search-outgoing-dto";

@Injectable({ providedIn: 'root' })
export class FAQService {
  public pathBase: string = `${connectionString}/faq`;

  constructor(private http: HttpClient) { }

  public SearchFAQ(searchParameters: FAQSearchOutgoingDto): Observable<FAQSearchIncomingDto> {
    return this.http.post<FAQSearchIncomingDto>(`${this.pathBase}/search`, searchParameters);
  }

  public CreateFAQ(faq: FAQDto): Observable<number> {
    return this.http.post<number>(`${this.pathBase}`, faq);
  }

  public DeleteFAQ(faqId: number): Observable<any> {
    return this.http.delete<any>(`${this.pathBase}/${faqId}`);
  }

  public UpdateFAQ(faqId: number, faq: FAQDto): Observable<FAQDto> {
    return this.http.put<FAQDto>(`${this.pathBase}/${faqId}`, faq);
  }

  public GetFAQById(id: number): Observable<FAQDto> {
    return this.http.get<FAQDto>(`${this.pathBase}/${id}`);
  }
}





