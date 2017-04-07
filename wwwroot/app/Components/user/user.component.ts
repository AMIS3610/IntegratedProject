import { Component } from '@angular/core';

import { AuthService } from '../../auth.service';

@Component({
    selector: 'user-home-page',
    templateUrl: './app/components/user/user.component.html'
})
export class UserComponent {
    //Was Quotes Component
    constructor(
        private authService: AuthService
    ){}
}