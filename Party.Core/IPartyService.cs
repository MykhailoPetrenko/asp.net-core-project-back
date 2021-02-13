using Party.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Party.Core
{
    public interface IPartyService
    {
        IEnumerable<Wydarzenie> GetWydarzenia();
        Wydarzenie GetUczestnikiWydarzenia(int wydarzenie);
    }
}
