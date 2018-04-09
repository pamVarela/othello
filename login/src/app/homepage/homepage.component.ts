import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {

  constructor (public authService: AuthService){

  }

  ngOnInit() {
  }


  visible=true;
  Pintar(matriz: Array<number> ){
  
    this.visible=!this.visible;
  
  }

  Mostrar(x:number, y:number) {
    
    console.log("x", x)
    console.log("y", y)
  }

  salir(){
    this.authService.logout();
  }
  


  
matriz=[[1,0,1,1,2,2,2,2],[2,2,2,2,2,2,2,2],[2,2,2,2,2,2,2,2],[2,2,2,1,0,2,2,2],[2,2,2,0,1,2,2,2],[2,2,2,2,2,2,2,2],[2,2,2,2,2,2,2,2],[2,2,2,2,2,2,2,2]]  
}



let jugador: Object = {
  correo: "Tu nombre",
  puntuacion: 29,
  victorias: 34,
  derrotas: 35,
  empates: 24

};

let color: string = "blue";


