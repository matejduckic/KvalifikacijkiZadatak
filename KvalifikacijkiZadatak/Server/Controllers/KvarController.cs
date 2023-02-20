using KvalifikacijkiZadatak.Server.Services;
using KvalifikacijkiZadatak.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KvalifikacijkiZadatak.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KvarController : ControllerBase
    {
        private readonly IKvaroviService _kvaroviService;

        public KvarController(IKvaroviService kvaroviService)
        {
            _kvaroviService = kvaroviService;
        }

        [HttpGet]
        public async Task<List<Kvarovi>> GetKvarove()
        {
            return await _kvaroviService.GetKvarove();
        }

        [HttpGet("{id}")]
        public async Task<Kvarovi?> GetKvarById(int id)
        {
            return await _kvaroviService.GetKvarById(id);
        }

        [HttpPost]
        public async Task<Kvarovi?> CreateKvar(Kvarovi kvarovi)
        {
            return await _kvaroviService.CreateKvar(kvarovi);
        }

        [HttpPut("{id}")]
        public async Task<Kvarovi?> UpdateKvar(int id, Kvarovi kvarovi)
        {
            return await _kvaroviService.UpdateKvar(id, kvarovi);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteKvar(int id)
        {
            return await _kvaroviService.DeleteKvar(id);
        }
    }
}
