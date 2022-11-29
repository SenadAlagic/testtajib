import {Component,OnInit} from "@angular/core";
import {FormControl, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'app-root',
  templateUrl:'registracijaVlasnik.component.html',
  styleUrls:['registracijaVlasnik.component.css']
})


export class RegistracijaVlasnikComponent implements OnInit {

  public hide: boolean = true;
  constructor() {
  }

  email = new FormControl('', [Validators.required, Validators.email]);
  ime = new FormControl('', [Validators.required]);
  prezime = new FormControl('', [Validators.required]);
  username = new FormControl('', [Validators.required]);
  password = new FormControl('', [Validators.required]);
  //TREBA ODRADITI VALIDACIJU PASSWORDA
  brRacuna=new FormControl('',[Validators.required]);
  brLicneKarte=new FormControl('',[Validators.required]);
  telefon=new FormControl('',[Validators.required]);

  getErrorMessage() {
    if (this.email.hasError('required')) {
      return 'You must enter a value';
    }
    if(this.email.hasError('email')){
      // @ts-ignore
      document.getElementById("matErorText").innerHTML='Not a valid email';
    }

    if(this.ime.hasError('required')) {
      return 'You must enter a value';
    }

    if(this.prezime.hasError('required')) {
      return 'You must enter a value';
    }

    if(this.telefon.hasError('required')) {
      return 'You must enter a value';
    }

    if(this.username.hasError('required')) {
      return 'You must enter a value';
    }

    if(this.password.hasError('required')) {
      return 'You must enter a value';
    }
    return this.password.hasError('username')? 'Not a valid password' : '';

    if(this.brRacuna.hasError('required')) {
      return 'You must enter a value';
    }

    if(this.brLicneKarte.hasError('required')){
      return 'You must enter a value';
    }

    //TREBA VALIDIRATI UNOS RACUNA DA SU SAMO BROJEVI
  }

  upload(event:Event){
    console.log(event)
  }

  ngOnInit() {
  }
}
