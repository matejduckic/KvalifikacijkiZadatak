using KvalifikacijkiZadatak.Shared;

namespace KvalifikacijkiZadatak.Client.Services
{
    public interface IStrojeviService
    {
        List<Strojevi> Strojevis { get; set; }
        Task GetStrojeve();
        Task<Strojevi> GetStrojById(int id);
        Task CreateStroj(Strojevi strojevi);
        Task DeleteStroj(int id);
        Task UpdateStroj(int id, Strojevi strojevi);
    }
}
