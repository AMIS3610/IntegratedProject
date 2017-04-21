import { Component } from '@angular/core';
import { AuthService } from '../../auth.service';

@Component({
    selector: 'mylistings-home-page',
    templateUrl: './app/Components/mylistings/mylistings.component.html'
})
export class MyListingsComponent {
    constructor(
        private authService: AuthService
    ){}    
}