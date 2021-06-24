import { CommonModule } from '@angular/common';
import { CardTextComponent } from './components/cards/card-text/card-text.component';
import { NgModule } from "@angular/core";
import { MaterialModule } from "./material.module";
import { PostPreviewHeadlineComponent } from './components/post-preview-headline/post-preview-headline.component';
import { CardExtendedComponent } from './components/cards/card-extended/card-extended.component';
import { CardShrinkedTextComponent } from './components/cards/card-shrinked-text/card-shrinked-text.component';
import { CardDefaultComponent } from './components/cards/card-default/card-default.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { CategoryTagComponent } from './components/category-tag/category-tag.component';
import { PostPreviewSidebarComponent } from './components/post-preview-sidebar/post-preview-sidebar.component';
import { CardCommentComponent } from './components/card-comment/card-comment.component';

@NgModule({
    declarations: [
        PostPreviewHeadlineComponent,
        CardTextComponent,
        CardExtendedComponent,
        CardShrinkedTextComponent,
        CardDefaultComponent,
        CategoryTagComponent,
        PostPreviewSidebarComponent,
        CardCommentComponent,
  ],
    imports: [
        CommonModule,
        MaterialModule,
        FlexLayoutModule,
    ],
    exports: [
        PostPreviewHeadlineComponent,
        CardTextComponent,
        CardExtendedComponent,
        CardShrinkedTextComponent,
        CardDefaultComponent,
        CategoryTagComponent,
        PostPreviewSidebarComponent,
        CardCommentComponent,
    ]
})

export class SharedModule {}