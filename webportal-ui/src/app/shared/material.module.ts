import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MatSliderModule } from "@angular/material/slider";
import { MatButtonModule } from "@angular/material/button";
import { MatIconModule } from '@angular/material/icon';

const modules = [
  MatSliderModule,
  MatButtonModule,
  MatIconModule,
];

@NgModule({
  imports: [CommonModule, ...modules],
  exports: [...modules]
})

export class MaterialModule {}