import {Component, OnInit} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import {MojConfig} from "../../../MojConfig";
import {FormControl, Validators} from "@angular/forms";
import {Router, RouterModule} from "@angular/router";


@Component({
  selector: 'app-root',
  templateUrl: 'registracijaGost.component.html',
  styleUrls: ['registracijaGost.component.css']
})

export class RegistracijaGostComponent implements OnInit {

  public hide: boolean = true;

  constructor(private httpklijent:HttpClient, private router:Router) {
  }

  email = new FormControl('', [Validators.required, Validators.email]);
  ime = new FormControl('', [Validators.required]);
  prezime = new FormControl('', [Validators.required]);
  username = new FormControl('', [Validators.required]);
  password = new FormControl('', [Validators.required]);
  passwordConfirm = new FormControl('', [Validators.required])
  datum_rodjenja = new FormControl(new Date().toLocaleDateString());
  year="";
  //TREBA ODRADITI VALIDACIJU PASSWORDA
  brLicneKarte = new FormControl('', [Validators.required]);
  telefon = new FormControl('', [Validators.required]);
  musko=new FormControl(false);
  zensko=new FormControl(false);
  getErrorMessage() {
    if (this.email.hasError('required')) {
      return 'You must enter a value';
    }
    if (this.email.hasError('email')) {
      // @ts-ignore
      return 'You must enter a valid email';
    }

    if (this.ime.hasError('required')) {
      return 'You must enter a value';
    }

    if (this.prezime.hasError('required')) {
      return 'You must enter a value';
    }

    if (this.telefon.hasError('required')) {
      return 'You must enter a value';
    }

    if (this.username.hasError('required')) {
      return 'You must enter a value';
    }

    if (this.password.hasError('required')) {
      return 'You must enter a value';
    }
    if (this.password != this.passwordConfirm) {
      return 'Passwords do not match';
    }
    if(this.passwordConfirm.hasError('required'))
      return 'You must enter a value';
    if(this.datum_rodjenja.hasError('required'))
    {
      return 'You must enter a value';
    }
    return this.password.hasError('username') ? 'Not a valid password' : '';
    //TODO validacija telefona tj da je validan broj
  }
  Validate() {
    this.year=String(this.datum_rodjenja.getRawValue()).substring(11,15);
    if(new Date().getFullYear()-13<parseInt(this.year))
    {
      return false;
    }
    if (this.email.hasError('required'))
      return false;
    if (this.email.hasError('email'))
      return false;
    if (this.ime.hasError('required'))
      return false;
    if (this.prezime.hasError('required'))
      return false;
    if (this.telefon.hasError('required'))
      return false;
    if (this.username.hasError('required'))
      return false;
    if (this.password.hasError('required'))
      return false;
    if (this.password.value != this.passwordConfirm.value)
    {
      console.log("pw nisu isti");
      return false;
    }
    return true;
  }

  Registracija() {
    if (!this.Validate())
      return;
    let spolNovi="Zenski";
    if(this.musko)
      spolNovi="Muski";
    let novi = {
      ime: this.ime.value,
      prezime: this.prezime.value,
      email: this.email.value,
      datumRodjenja: this.datum_rodjenja.value,
      spol: spolNovi,
      brojTelefona: this.telefon.value,
      username: this.username.value,
      password: this.password.value,
    };
    //this.httpklijent.post(MojConfig.adresa_servera+'/api/Korisnik/RegistracijaGost',novi).subscribe(x=>{
    //  this.router.navigate([""]);
    //});
    this.httpklijent.get(MojConfig.adresa_servera+'/api/Korisnik/gettest').subscribe(x=>{
      console.log("success");
    })
  }

  upload(event: Event) {
    console.log(event)
  }

  ngOnInit() {

  }
}
