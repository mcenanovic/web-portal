import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MatSliderModule } from "@angular/material/slider";
import { MatButtonModule } from "@angular/material/button";

const modules = [
  MatSliderModule,
  MatButtonModule,
];

@NgModule({
  imports: [CommonModule, ...modules],
  exports: [...modules]
})

export class MaterialModule {}