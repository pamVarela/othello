
import { AppRoutingModule} from './app-routing.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }  from '@angular/forms';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { MatButtonModule, MatCheckboxModule} from '@angular/material';
import { HttpModule} from '@angular/http';  

import { AngularFireModule} from 'angularfire2';
import { AngularFireAuthModule} from 'angularfire2/auth';
import { AngularFireDatabaseModule } from 'angularfire2/database'
import { AppComponent } from './app.component';
import { LoginComponent} from './login/login.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ProfileComponent } from './profile/profile.component';
import { AuthService} from '../app/services/auth.service';
import { WebserviceService} from '../app/services/webservice.service' ; 

const firebaseConfig = {
    apiKey: "AIzaSyCahavngZcn0hXsK54Kv1z24T-e3iTofHQ",
    authDomain: "login-4136f.firebaseapp.com",
    databaseURL: "https://login-4136f.firebaseio.com",
    projectId: "login-4136f",
    storageBucket: "login-4136f.appspot.com",
    messagingSenderId: "476385947404"
};

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomepageComponent,
    ProfileComponent,
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    [BrowserAnimationsModule],
    [MatButtonModule, MatCheckboxModule],
    AngularFireModule.initializeApp(firebaseConfig),
    AngularFireAuthModule,
    AngularFireDatabaseModule,
    HttpModule

  ],
  providers: [AuthService,WebserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
