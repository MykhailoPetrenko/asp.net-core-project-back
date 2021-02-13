using Party.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Party.Core
{
    public interface IPartyService
    {
        IEnumerable<Wydarzenie> GetWydarzenia();
        IEnumerable<Uczestnik> GetUczestnikiWydarzenia(int wydarzenie);
    }
}
