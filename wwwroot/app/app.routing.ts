import { ModuleWithProviders } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

import { HomeComponent } from './components/home/home.component';
import { UserComponent } from './components/user/user.component';
import { ListingsComponent } from './components/listings/listings.component';
import { LoginComponent } from './components/login/login.component';



const appRoutes: Routes = [
    {
        path: "",
        component: HomeComponent
    },
    {
        path: "home",
        redirectTo: ""
    },
    {
        path: "user",
        component: UserComponent
    },
    {
        path: "listings",
        component: ListingsComponent
    },
    {
        path: "login",
        component: LoginComponent
    }
];

export const AppRoutingProviders: any[] = [
];

export const AppRouting: ModuleWithProviders = RouterModule.forRoot(appRoutes);
