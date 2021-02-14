using Party.DB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Party.Core
{
    public interface IPartyService
    {
        IEnumerable<Wydarzenie> GetWydarzenia();
        Wydarzenie GetUczestnikiWydarzenia(int wydarzenie);
        IEnumerable<Wydarzenie> GetWydarzeniaByDate(DateTime data);
        Task<Wydarzenie> CreateWydarzenie(Wydarzenie wydarzenie, string userId);
    }
}
