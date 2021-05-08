import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MatSliderModule } from "@angular/material/slider";

const modules = [
  MatSliderModule,
];

@NgModule({
  imports: [CommonModule, ...modules],
  exports: [...modules]
})

export class MaterialModule {}