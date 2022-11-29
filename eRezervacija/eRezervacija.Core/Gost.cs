using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eRezervacija.Core
{
	public class Gost
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("KorisnikID")]
		public Korisnik korisnik { get; set; }
		public int KorisnikID { get; set; }
	}
}
