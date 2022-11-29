using eRezervacija.API.ViewModels;
using eRezervacija.Core;
using eRezervacija.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRezervacija.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class KorisnikController : ControllerBase
	{
		IKorisnikService korisnikService;
		public KorisnikController(IKorisnikService korisnikService)
		{
			this.korisnikService = korisnikService;
		}
		[HttpPost]
		public Korisnik RegistracijaGost(RegistracijaGostVM gost)
		{
			var temp = new Korisnik()
			{
				Uloga = "Gost",
				Ime = gost.Ime,
				Prezime = gost.Prezime,
				Spol = gost.Spol,
				Datum_rodjenja = gost.DatumRodjenja,
				Email = gost.Email,
				Broj_telefona = gost.BrojTelefona,
				Username = gost.Username,
				Password = gost.Password,
				DatumKreiranja = DateTime.Now,
				DatumPromjene = DateTime.Now
			};
			korisnikService.Add(temp);
			return temp;
		}

		[HttpGet]
		public IActionResult gettest()
		{
			return Ok();
		}
	}
}
