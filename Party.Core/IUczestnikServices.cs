using System.Threading.Tasks;
using Party.DB;

namespace Party.Core
{
    public interface IUczestnikServices
    {
        Task<Uczestnik> AddUczestnikToWydarzenie(int IdWydarzenie, string IdUczestnik);
    }
}