import { Injectable } from '@angular/core';
import {Router, Routes,RouterModule} from '@angular/router';
import { AngularFireAuth } from 'angularfire2/auth';
import * as firebase from 'firebase/app';
import {Observable} from 'rxjs/Observable';

@Injectable()
export class AuthService{

  private user: Observable <firebase.User>;
  private userDetails: firebase.User = null;

  constructor(public afAuth: AngularFireAuth, public router: Router) {

      this.user = afAuth.authState;

      this.user.subscribe(
        (user) => {
          if (user) {
            this.userDetails = user;
            console.log(this.userDetails);
          }
          else {
            this.userDetails = null;
          }
        }
      );
  
    }
  isLoggedIn() {
  if (this.userDetails == null ) {
      return false;
    } else {
      return true;
    }
  }

  googleLogin() {
    const provider = new firebase.auth.GoogleAuthProvider();
    this.afAuth.auth.signInWithPopup(provider).then(value=>{
      this.router.navigate(['/homepage'])
    })
     
  }
  logout(){
    this.afAuth.auth.signOut().then(() => {
      window.location.assign('https://accounts.google.com/Logout');
    }
  )};
 
}

