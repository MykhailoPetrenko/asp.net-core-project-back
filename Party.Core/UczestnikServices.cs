using System.Linq;
using System.Threading.Tasks;
using Party.DB;

namespace Party.Core
{
    public class UczestnikServices: IUczestnikServices
    {
        private readonly AppDbContext _context;
        public UczestnikServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Uczestnik> AddUczestnikToWydarzenie(int IdWydarzenie, string IdUczestnik)
        {
            Uczestnik ucestnik = _context.Uczestnik.FirstOrDefault(u => u.IdOsoba == IdUczestnik);
            Wydarzenie wydarzenie = _context.Wydarzenies.FirstOrDefault(w => w.IdWydarzenie == IdWydarzenie);
            if (ucestnik != null)
            {
                _context.UczestnikWydarzenie.Add(new UczestnikWydarzenie()
                {
                    Wydarzenie = wydarzenie,
                    Uczestnik = ucestnik
                });
            }
                //if (ucestnik.UczestnikWydarzenie.Where(t => t.IdUczestnik == IdUczestnik).ToList().Count == 0)
                //{
 
                //}
            await _context.SaveChangesAsync();
            return ucestnik;
        }
    }
}