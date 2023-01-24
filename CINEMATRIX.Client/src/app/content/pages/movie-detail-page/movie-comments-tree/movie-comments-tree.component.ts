import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
import { MovieCommentFoundIncomingDto } from 'src/app/core/models/movie-comment/movie-comment-found-incoming-dto';

@Component({
  selector: 'app-movie-comments-tree',
  templateUrl: './movie-comments-tree.component.html',
  styleUrls: ['./movie-comments-tree.component.scss']
})
export class MovieCommentTreeComponent implements OnInit {
  @Input() comment: MovieCommentFoundIncomingDto;

  constructor(private router: Router) {}

  ngOnInit() { }

  redirectToProfile(profileId: number) {
    this.router.navigate(['/profile/' + profileId]);
  }

}

