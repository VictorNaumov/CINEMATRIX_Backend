import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-error',
  templateUrl: './error.component.html',
  styleUrls: ['./error.component.scss']
})
export class ErrorComponent implements OnInit {

errorSrc:string = "https://img.freepik.com/free-vector/tiny-people-examining-operating-system-error-warning-web-page-isolated-flat-illustration_74855-11104.jpg?w=996&t=st=1668529853~exp=1668530453~hmac=2ff72d31f613204850643cfbbe8eceea0bc7b2e088c32755857913c39e058a05;"

  constructor() { }

  ngOnInit(): void {
  }

}
