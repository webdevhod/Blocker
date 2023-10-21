import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";

import { SharedModule } from "app/shared/shared.module";
import { HOME_ROUTE } from "./home.route";
import { HomeComponent } from "./home.component";
import {BrowserModule} from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { DropdownModule } from 'primeng/dropdown';
import { TabMenuModule } from 'primeng/tabmenu';

@NgModule({
  imports: [SharedModule, RouterModule.forChild([HOME_ROUTE]), BrowserModule, BrowserAnimationsModule, DropdownModule, TabMenuModule],
  declarations: [HomeComponent],
})
export class HomeModule {}
