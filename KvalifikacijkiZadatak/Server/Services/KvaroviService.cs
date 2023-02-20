using KvalifikacijkiZadatak.Server.Data;
using KvalifikacijkiZadatak.Shared;
using Microsoft.EntityFrameworkCore;

namespace KvalifikacijkiZadatak.Server.Services
{
    public class KvaroviService : IKvaroviService
    {
        private readonly DataContext _context;

        public KvaroviService(DataContext context)
        {
            _context = context;
        }

        public async Task<Kvarovi> CreateKvar(Kvarovi kvarovi)
        {
            _context.Add(kvarovi);
            await _context.SaveChangesAsync();
            return kvarovi;
        }

        public async Task<bool> DeleteKvar(int Id)
        {
            var dbKvarovi = await _context.Kvarovis.FindAsync(Id);
            if (dbKvarovi == null)
            {
                return false;
            }

            _context.Remove(dbKvarovi);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Kvarovi?> GetKvarById(int Id)
        {
            var dbKvarovi = await _context.Kvarovis.FindAsync(Id);
            return dbKvarovi;
        }

        public async Task<List<Kvarovi>> GetKvarove()
        {
            return await _context.Kvarovis.ToListAsync();
        }

        public async Task<Kvarovi?> UpdateKvar(int Id, Kvarovi kvarovi)
        {
            var dbKvarovi = await _context.Kvarovis.FindAsync(Id);
            if (dbKvarovi != null)
            {
                dbKvarovi.Ime = kvarovi.Ime;
                dbKvarovi.Prioritet = kvarovi.Prioritet;
                dbKvarovi.Pocetak = kvarovi.Pocetak;
                dbKvarovi.Zavrsetak = kvarovi.Zavrsetak;
                dbKvarovi.DetaljniOpis = kvarovi.DetaljniOpis;
                dbKvarovi.Status = kvarovi.Status;

                await _context.SaveChangesAsync();
            }

            return dbKvarovi;
        }
    }
}
