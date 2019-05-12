import { NgModule } from "@angular/core";
import { StaticDataSource } from "./datasource.model";
import { Model } from "./repository.model";
import { HttpModule } from "@angular/http";

@NgModule({
    imports: [HttpModule],
    providers: [Model, StaticDataSource]
})
export class ModelModule { }
