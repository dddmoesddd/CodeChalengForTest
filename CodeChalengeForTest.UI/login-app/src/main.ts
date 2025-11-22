import { bootstrapApplication } from '@angular/platform-browser';
import { importProvidersFrom } from '@angular/core';
import { provideRouter } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app/app';
import { LoginComponent } from './app/pages/login/login'

bootstrapApplication(AppComponent, {
  providers: [
    importProvidersFrom(HttpClientModule),

    // Provide routes here
    provideRouter([
      { path: '', component: LoginComponent }, // default route
      { path: 'login', component: LoginComponent } // optional route /login
    ])
  ]
}).catch(err => console.error(err));
