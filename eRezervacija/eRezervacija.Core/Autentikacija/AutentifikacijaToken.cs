using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core.Autentikacija
{
	public class AutentifikacijaToken
	{
		[Key]
		public int Id { get; set; }
		public string Vrijednost { get; set; }
		[ForeignKey("KorisnikID")]
		public Korisnik korisnik { get; set; }
		public int KorisnikID { get; set; }
		//public DateTime VrijemeEvidentiranja { get; set; }
		public string? ipAdresa { get; set; }
	}
}
