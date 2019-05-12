import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { CommonModule } from "../common/common.module";
import { FormsModule, ReactiveFormsModule } from "@angular/forms"
import { PaDiscountDisplayComponent } from "./discountDisplay.component";
import { PaDiscountEditorComponent } from "./discountEditor.component";
import { ProductFormComponent } from "./productForm.component";
import { ProductTableComponent } from "./productTable.component";
import { ProductComponent } from "./component";

@NgModule({
    imports: [BrowserModule, FormsModule, ReactiveFormsModule, CommonModule],
    declarations: [ProductComponent, PaDiscountDisplayComponent, PaDiscountEditorComponent,
                   ProductFormComponent, ProductTableComponent],
    exports: [ProductComponent, ProductFormComponent, ProductTableComponent]
})

export class ComponentsModule { }
