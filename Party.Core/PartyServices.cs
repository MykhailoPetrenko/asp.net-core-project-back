using Party.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Party.Core
{
    public class PartyServices: IPartyService
    {
        private readonly AppDbContext _context;
        public PartyServices(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Wydarzenie> GetWydarzenia()
        {
            return _context.Wydarzenies.ToList();
        }

        public IEnumerable<Uczestnik> GetUczestnikiWydarzenia(int wydarzenie)
        {
            return  _context.UczestnikWydarzenie
                .Where(uw => uw.IdWydarzenie == wydarzenie)
                .Select(s => s.IdUczestnikNavigation)
                .ToList();
        }
    }
}
