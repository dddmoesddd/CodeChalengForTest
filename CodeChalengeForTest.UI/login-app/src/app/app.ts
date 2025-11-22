import { Component } from '@angular/core';
import { LoginComponent } from './pages/login/login';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  styleUrls: ['./app.css'],
  standalone: true,
  imports: [LoginComponent]
})
export class AppComponent {

  title() {
    return "login app" 
  }
}
