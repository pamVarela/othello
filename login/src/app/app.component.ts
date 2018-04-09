
import { Component } from '@angular/core';  
import { WebserviceService} from '../app/services/webservice.service'

@Component({  
  selector: 'app-root',  
  templateUrl: './app.component.html',  
  styleUrls: ['./app.component.css']  
})  
export class AppComponent {  
  items: string[];   
  constructor(private appService: WebserviceService)  
  {  
    this.items = [];  
    this.populateItems();  
    }  
  
    populateItems()  
    {  
      this.appService.getItems().subscribe(res =>{  
        this.items = res;  
      })  
    }  
}
 