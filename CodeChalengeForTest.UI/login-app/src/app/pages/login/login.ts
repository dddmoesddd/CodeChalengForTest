import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { AuthService, LoginResponse } from '../../../services/auth';

@Component({
  selector: 'app-login',
  templateUrl: './login.html',
  styleUrls: ['./login.css'],
  standalone: true,
  imports: [FormsModule, CommonModule],
})
export class LoginComponent {
  username: string = '';
  password: string = '';
  loginSuccess: boolean | null = null; // null = no attempt yet
  message: string = '';

  constructor(private authService: AuthService) { }

  login() {
    this.authService.login({ username: this.username, password: this.password })
      .subscribe({
        next: (res: LoginResponse) => {
          this.loginSuccess = true;
          this.message = 'Login successful! Token: ' + res.token;
          console.log('Token:', res.token);
        },
        error: (err) => {
          this.loginSuccess = false;
          this.message = 'Login failed';
          console.error(err);
        }
      });
  }
}
