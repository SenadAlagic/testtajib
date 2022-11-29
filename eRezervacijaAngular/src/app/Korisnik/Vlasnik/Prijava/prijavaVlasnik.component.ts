import {Component,OnInit} from "@angular/core";


@Component({
  selector: 'app-root',
  templateUrl:'prijavaVlasnik.component.html',
  styleUrls:['prijavaVlasnik.component.css']
})

export class PrijavaVlasnikComponent implements OnInit {

  public hide: boolean = true;

  constructor() {
  }


  ngOnInit():void {
  }
}
