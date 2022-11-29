import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{HttpClientModule} from "@angular/common/http";
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {RouterModule, RouterOutlet} from "@angular/router";
import {MatButtonModule} from '@angular/material/button';
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {ReactiveFormsModule} from '@angular/forms';
import {MatIconModule} from '@angular/material/icon';
import {MatDividerModule} from '@angular/material/divider';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatRadioModule} from '@angular/material/radio';
import {MatNativeDateModule} from "@angular/material/core";
import {MatTooltipModule} from '@angular/material/tooltip';

import {PocetnaComponent} from "./PocetnaComponent/pocetna.component";
import {PrijavaVlasnikComponent} from "./Korisnik/Vlasnik/Prijava/prijavaVlasnik.component";
import {RegistracijaVlasnikComponent} from "./Korisnik/Vlasnik/Registracija/registracijaVlasnik.component";
import {RegistracijaGostComponent} from "./Korisnik/Gost/Registracija/registracijaGost.component";


@NgModule({
  declarations: [
    AppComponent,
    PocetnaComponent,
    PrijavaVlasnikComponent,
    RegistracijaVlasnikComponent,
    RegistracijaGostComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatInputModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatIconModule,
    MatDividerModule,
    MatDatepickerModule,
    MatRadioModule,
    MatNativeDateModule,
    MatTooltipModule,
    HttpClientModule,
    RouterModule.forRoot(
      [
        //ovdje idu rute
        { path: '', component: PocetnaComponent}, //ovako smo postavili PocetnaComponent kao pocetni page
        { path: 'putanja-prijavaVlasnik', component: PrijavaVlasnikComponent},
        { path: 'putanja-registracijaVlasnik', component:RegistracijaVlasnikComponent},
        { path: 'putanja-registracijaGost', component: RegistracijaGostComponent}
      ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
