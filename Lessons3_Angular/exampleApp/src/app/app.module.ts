import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule, ReactiveFormsModule  } from "@angular/forms";
import { ModelModule } from "./model/model.module";

@NgModule({
    imports: [BrowserModule, FormsModule, ReactiveFormsModule,
              ModelModule],
    bootstrap: []
})
export class AppModule {}
