using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
	public interface IKorisnikService
	{
		void Add(Korisnik obj);
		IEnumerable<Korisnik> GetAll();
	}
	public class KorisnikService : IKorisnikService
	{
		IRepository<Korisnik> korisnikRepository;
		public KorisnikService(IRepository<Korisnik> korisnikRepository)
		{
			this.korisnikRepository = korisnikRepository;
		}

		public void Add(Korisnik obj)
		{
			korisnikRepository.Add(obj);
		}

		public IEnumerable<Korisnik> GetAll()
		{
			return korisnikRepository.GetAll();
		}
	}
}