import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import 'rxjs/Rx';

import { AppComponent } from './app.component';
import { HomeComponent } from './Components/home/home.component';
import { NavBarComponent } from './Components/navbar/navbar.component';
import { LoginComponent } from './Components/login/login.component';
import { ListingsComponent } from './Components/listings/listings.component';
import { UserComponent } from './Components/user/user.component';
import { MyListingsComponent } from './Components/mylistings/mylistings.component'

import { AppRouting } from './app.routing';
import { AuthService } from "./auth.service";
import { AuthHttp } from "./auth.http";


@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        NavBarComponent,
        LoginComponent,
        UserComponent,
        ListingsComponent,
        MyListingsComponent
    ],
    imports: [
        BrowserModule,
        HttpModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        AppRouting
    ],
    providers: [
        AuthService,
        AuthHttp
    ],
    bootstrap: [
        AppComponent
    ],
})
export class AppModule { }