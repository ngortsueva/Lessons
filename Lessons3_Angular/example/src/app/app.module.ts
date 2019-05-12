import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule, ReactiveFormsModule  } from "@angular/forms";
import { ModelModule } from "./model/model.module";
import { CommonModule } from "./common/common.module";
import { ComponentsModule } from "./components/components.module";
import { ProductComponent } from "./components/component";

@NgModule({
    imports: [BrowserModule, FormsModule, ReactiveFormsModule,
              ModelModule, CommonModule, ComponentsModule],
    bootstrap: [ProductComponent]
})
export class AppModule {}
