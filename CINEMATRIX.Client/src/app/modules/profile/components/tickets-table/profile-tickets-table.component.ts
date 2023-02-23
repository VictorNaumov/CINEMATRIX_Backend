import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { Router } from '@angular/router';
import { MovieCommentFoundIncomingDto } from 'src/app/core/models/movie-comment/movie-comment-found-incoming-dto';
import { TicketFoundIncomingDto } from 'src/app/core/models/ticket/ticket-found-incoming-dto';

@Component({
  selector: 'app-profile-tickets-table',
  templateUrl: './profile-tickets-table.component.html',
  styleUrls: ['./profile-tickets-table.component.scss']
})
export class ProfileTicketsComponent implements OnInit {
  @Input() tickets: TicketFoundIncomingDto[];

  @ViewChild(MatPaginator) paginator: MatPaginator;

  displayedColumns: string[] = ['id', 'ticketId', 'seatType', 'seat', 'sessionId', 'date', 'hall', 'movieTitle', 'goToMovie'];
  dataSource: any;

  constructor(private router: Router) { }

  ngOnInit() {
    this.dataSource = new MatTableDataSource<TicketFoundIncomingDto>(this.tickets);
    this.paginator.pageSize = 10;
    this.dataSource.paginator = this.paginator;
  }
}

