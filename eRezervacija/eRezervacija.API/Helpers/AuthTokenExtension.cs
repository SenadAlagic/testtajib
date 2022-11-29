using eRezervacija.Core;
using eRezervacija.Core.Autentikacija;
using eRezervacija.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace eRezervacija.API.Helpers
{
	public static class AuthTokenExtension
	{
		public class LoginInformacije
		{
			[JsonIgnore]
			public Korisnik? korisnickiNalog => autentifikacijaToken?.korisnik;
			public AutentifikacijaToken? autentifikacijaToken { get; set; }
			public bool isLogiran => korisnickiNalog != null;

			public LoginInformacije(AutentifikacijaToken? autentifikacijaToken)
			{
				this.autentifikacijaToken = autentifikacijaToken;
			}
		}
		public static LoginInformacije GetLoginInfo(this HttpContext httpContext)
		{
			var token = httpContext.GetAuthToken();

			return new LoginInformacije(token);
		}

		public static AutentifikacijaToken? GetAuthToken(this HttpContext httpContext)
		{
			string token = httpContext.GetMyAuthToken();
			eRezervacijaDbContext db = httpContext.RequestServices.GetService<eRezervacijaDbContext>();

			AutentifikacijaToken? korisnik = db.AutentifikacijaTokeni
				.Include(s => s.korisnik)
				.SingleOrDefault(x => x.Vrijednost == token);

			return korisnik;
		}


		public static string GetMyAuthToken(this HttpContext httpContext)
		{
			string token = httpContext.Request.Headers["autentifikacija-token"];
			return token;
		}
	}
}
