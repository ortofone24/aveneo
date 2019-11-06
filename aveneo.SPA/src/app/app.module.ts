import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AveneoComponent } from './aveneo/aveneo.component';
import { BusinessEntityService } from './_services/businessEntity.service';


@NgModule({
   declarations: [
      AppComponent,
      AveneoComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      ReactiveFormsModule
   ],
   providers: [
      BusinessEntityService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
