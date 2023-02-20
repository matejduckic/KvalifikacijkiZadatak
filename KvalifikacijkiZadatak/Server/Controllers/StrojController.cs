using KvalifikacijkiZadatak.Server.Services;
using KvalifikacijkiZadatak.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KvalifikacijkiZadatak.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StrojController : ControllerBase
    {
        private readonly IStrojeviService _strojeviService;

        public StrojController(IStrojeviService strojeviService)
        {
            _strojeviService = strojeviService;
        }

        [HttpGet]
        public async Task<List<Strojevi>> GetStrojeve()
        {
            return await _strojeviService.GetStrojeve();
        }

        [HttpGet("{id}")]
        public async Task<Strojevi?> GetStrojById(int id)
        {
            return await _strojeviService.GetStrojById(id);
        }

        [HttpPost]
        public async Task<Strojevi?> CreateStroj(Strojevi strojevi)
        {
            return await _strojeviService.CreateStroj(strojevi);
        }

        [HttpPut("{id}")]
        public async Task<Strojevi?> UpdateStroj(int id, Strojevi strojevi)
        {
            return await _strojeviService.UpdateStroj(id, strojevi);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteStroj(int id)
        {
            return await _strojeviService.DeleteStroj(id);
        }
    }
}
