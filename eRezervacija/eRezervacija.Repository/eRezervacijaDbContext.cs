using eRezervacija.Core;
using eRezervacija.Core.Autentikacija;
using Microsoft.EntityFrameworkCore;

namespace eRezervacija.Repository
{
	public class eRezervacijaDbContext : DbContext
	{
		public eRezervacijaDbContext(DbContextOptions<eRezervacijaDbContext> options) : base(options)
		{

		}
		public DbSet<Drzava> Drzave { get; set; }
		public DbSet<Grad> Gradovi { get; set; }
		public DbSet<Korisnik> Korisnici { get; set; }
		public DbSet<Gost> Gosti { get; set; }
		public DbSet<Vlasnik> Vlasnici { get; set; }
		public DbSet<Admin> Admini { get; set; }
		public DbSet<AutentifikacijaToken> AutentifikacijaTokeni { get; set; }
	}
}