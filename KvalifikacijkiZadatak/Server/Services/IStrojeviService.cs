using KvalifikacijkiZadatak.Shared;

namespace KvalifikacijkiZadatak.Server.Services
{
    public interface IStrojeviService
    {
        Task<List<Strojevi>> GetStrojeve();
        Task<Strojevi?> GetStrojById(int Id);
        Task<Strojevi> CreateStroj(Strojevi strojevi);
        Task<Strojevi?> UpdateStroj(int Id, Strojevi strojevi);
        Task<bool> DeleteStroj(int Id);
    }
}
