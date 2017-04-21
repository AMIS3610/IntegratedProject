import { ModuleWithProviders } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

import { HomeComponent } from './Components/home/home.component';
import { UserComponent } from './Components/user/user.component';
import { ListingsComponent } from './Components/listings/listings.component';
import { LoginComponent } from './Components/login/login.component';
import { MyListingsComponent } from './Components/mylistings/mylistings.component'



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
        path: "mylistings",
        component: MyListingsComponent
    },
    {
        path: "login",
        component: LoginComponent
    }
];

export const AppRoutingProviders: any[] = [
];

export const AppRouting: ModuleWithProviders = RouterModule.forRoot(appRoutes);
