using KvalifikacijkiZadatak.Shared;

namespace KvalifikacijkiZadatak.Client.Services
{
    public interface IKvaroviService
    {
        List<Kvarovi> Kvarovis { get; set; }
        Task GetKvarove();
        Task<Kvarovi?> GetKvarById(int id);
        Task CreateKvar(Kvarovi kvarovi);
        Task UpdateKvar(int id, Kvarovi kvarovi);
        Task DeleteKvar(int id);
    }
}
