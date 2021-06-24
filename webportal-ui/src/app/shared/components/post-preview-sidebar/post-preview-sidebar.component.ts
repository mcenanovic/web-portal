import { Component, Input } from '@angular/core';

@Component({
  selector: 'wp-post-preview-sidebar',
  templateUrl: './post-preview-sidebar.component.html',
  styleUrls: ['./post-preview-sidebar.component.scss']
})
export class PostPreviewSidebarComponent {
  @Input() title: string = 'Posts';
}
