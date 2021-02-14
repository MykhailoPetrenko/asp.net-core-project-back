using System.Threading.Tasks;
using Party.DB;

namespace Party.Core
{
    public class UserServices: IUserServises
    {
        
        private readonly AppDbContext _context;
        public UserServices(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Uczestnik> RegisterUczestnik(string IdUczestnik, string email)
        {
            Uczestnik uczestnik = new Uczestnik()
            {
                Email = email,
                IdOsoba = IdUczestnik,
                Imie = IdUczestnik,
                Nazwisko = "test",
                Status = "user",
                Wiek = 18
            };
            Tworca tworca = new Tworca()
            {
                Email = email,
                IdOsoba = IdUczestnik,
                Imie = IdUczestnik,
                Nazwisko = "test",
                NrKonta = "123",
                StanKonta = 0,
                Wiek = 18
            };
            await _context.Uczestnik.AddAsync(uczestnik);
            await _context.Tworca.AddAsync(tworca);
            await _context.SaveChangesAsync();
            return uczestnik;
        }
    }
}