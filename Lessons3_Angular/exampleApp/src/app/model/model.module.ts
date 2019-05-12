import { NgModule } from "@angular/core";
import { StaticDataSource } from "./datasource.model";
import { Model } from "./repository.model";

@NgModule({
    providers: [Model, StaticDataSource]
})
export class ModelModule { }
