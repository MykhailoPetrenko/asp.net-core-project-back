using System.Threading.Tasks;
using Party.DB;

namespace Party.Core
{
    public interface IUserServises
    {
        Task<Uczestnik> RegisterUczestnik(string IdUczestnik, string email);
    }
}