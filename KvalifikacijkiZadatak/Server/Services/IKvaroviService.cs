using KvalifikacijkiZadatak.Shared;

namespace KvalifikacijkiZadatak.Server.Services
{
    public interface IKvaroviService
    {
        Task<List<Kvarovi>> GetKvarove();
        Task<Kvarovi?> GetKvarById(int Id);
        Task<Kvarovi> CreateKvar(Kvarovi kvarovi);
        Task<Kvarovi?> UpdateKvar(int Id, Kvarovi kvarovi);
        Task<bool> DeleteKvar(int Id);
    }
}
