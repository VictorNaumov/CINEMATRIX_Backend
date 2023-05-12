import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { Observable } from 'rxjs';
import { FAQFoundIncomingDto } from 'src/app/core/models/faq/faq';
import { FAQSearchIncomingDto } from 'src/app/core/models/faq/faq-search-incoming-dto';
import { FAQSearchOutgoingDto } from 'src/app/core/models/faq/faq-search-outgoing-dto';
import { FAQService } from 'src/app/core/services/faq.service';
import { errorMessage } from 'src/app/shared/constants/error.message.contants';
import { setBasicPageParams } from 'src/app/shared/functions/setBasicPageParams';

@Component({
  selector: 'app-faq',
  templateUrl: './faq.component.html',
  styleUrls: ['./faq.component.scss']
})
export class FAQComponent implements OnInit {
  public isError: boolean = false;
  public query$: Observable<any> | undefined;
  public faqs: FAQFoundIncomingDto[];
  public groupedFAQs: { category: string, faqs: FAQFoundIncomingDto[] }[];

  constructor(private faqService: FAQService,
    private snackBar: MatSnackBar) { }

  ngOnInit() {
    this.sendFAQQuery();
  }

  sendFAQQuery() {
    let startDateTime: Date = new Date();
    startDateTime.setFullYear(2001, 12, 10);

    let endDateTime: Date = new Date();
    endDateTime.setFullYear(2025, 12, 10);

    let FAQsParam: FAQSearchOutgoingDto = {
      "pageSize": 20,
      "question": [],
      "answer": [],
      "category": []
    }

    this.query$ = this.faqService.SearchFAQ(FAQsParam);

    this.query$.subscribe((faqSearchIncomingDto: FAQSearchIncomingDto) => {
      this.faqs = faqSearchIncomingDto.items;
      this.groupedFAQs = this.groupFaqsByCategory();
    });

    // this.checkError(this.query$);
  }

  groupFaqsByCategory(): { category: string, faqs: FAQFoundIncomingDto[] }[] {
    const categories: string[] = this.faqs.map(faq => faq.category).filter((item, index, self) => self.indexOf(item) === index);
    return categories.map(category => {
      return {
        category: category,
        faqs: this.faqs.filter(faq => faq.category === category)
      };
    });
  }

  // checkError(sub: Observable<any>): void {
  //   sub.subscribe(
  //     (_) => { console.log(_) },
  //     error => {
  //       this.isError = true;
  //       this.snackBar.open(errorMessage, "Close")
  //     })
  // }
}
