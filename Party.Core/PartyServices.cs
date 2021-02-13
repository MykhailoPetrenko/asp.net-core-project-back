using Party.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Party.Core
{
    class PartyServices
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
    }
}
