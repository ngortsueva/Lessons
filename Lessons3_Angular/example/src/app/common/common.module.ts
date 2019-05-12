import { NgModule } from "@angular/core";;
import { PaAddTaxPipe } from "./addTax.pipe"
import { PaAttrDirective } from "./attr.directive";
import { PaCategoryFilterPipe } from "./categoryFilter.pipe";
import { PaCellColor } from "./cellColor.directive";
import { PaCellColorSwitcher } from "./cellColorSwitcher.directive";
import { PaDiscountPipe } from "./discount.pipe";
import { PaDiscountAmountDirective } from "./discountAmount.directive";
import { PaStructureDirective } from "./structure.directive";
import { PaIteratorDirective } from "./iterator.directive";
import { PaModel } from "./twoway.directive";
import { DiscountService } from "./discount.service";
import { LogService } from "./log.service";
import { ModelModule } from "../model/model.module";

@NgModule({
    imports: [ModelModule],
    declarations: [PaAddTaxPipe, PaAttrDirective, PaCategoryFilterPipe,
                   PaModel, PaCellColor, PaCellColorSwitcher, PaDiscountPipe,
                   PaDiscountAmountDirective, PaStructureDirective, PaIteratorDirective,
                   PaModel],
    providers: [DiscountService, LogService],
    exports: [PaAddTaxPipe, PaAttrDirective, PaCategoryFilterPipe,
              PaCellColor, PaCellColorSwitcher, PaDiscountPipe,
              PaDiscountAmountDirective, PaIteratorDirective, PaStructureDirective,
              PaModel]
})
export class CommonModule {}
