using KvalifikacijkiZadatak.Shared;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;

namespace KvalifikacijkiZadatak.Client.Services
{
    public class StrojeviService : IStrojeviService
    {

        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManger;

        public StrojeviService(HttpClient http, NavigationManager navigationManger)
        {
            _http = http;
            _navigationManger = navigationManger;
        }

        public List<Strojevi> Strojevis { get; set; } = new List<Strojevi>();

        public async Task CreateStroj(Strojevi strojevi)
        {
            await _http.PostAsJsonAsync("api/stroj", strojevi);
            _navigationManger.NavigateTo("strojevi");
        }

        public async Task DeleteStroj(int id)
        {
            var result = await _http.DeleteAsync($"api/stroj/{id}");
            _navigationManger.NavigateTo("strojevi");
        }

        public async Task<Strojevi?> GetStrojById(int id)
        {
            var result = await _http.GetAsync($"api/stroj/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Strojevi>();
            }
            return null;
        }

        public async Task GetStrojeve()
        {
            var result = await _http.GetFromJsonAsync<List<Strojevi>>("api/stroj");
            if (result is not null)
                Strojevis = result;
        }

        public async Task UpdateStroj(int id, Strojevi strojevi)
        {
            await _http.PutAsJsonAsync($"api/stroj/{id}", strojevi);
            _navigationManger.NavigateTo("strojevi");
        }
    }
}
