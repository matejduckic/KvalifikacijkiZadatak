using KvalifikacijkiZadatak.Shared;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;

namespace KvalifikacijkiZadatak.Client.Services
{
    public class KvaroviService : IKvaroviService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManger;

        public KvaroviService(HttpClient http, NavigationManager navigationManger)
        {
            _http = http;
            _navigationManger = navigationManger;
        }

        public List<Kvarovi> Kvarovis { get; set; } = new List<Kvarovi>();

        public async Task CreateKvar(Kvarovi kvarovi)
        {
            await _http.PostAsJsonAsync("api/kvar", kvarovi);
            _navigationManger.NavigateTo("kvarovi");
        }

        public async Task DeleteKvar(int id)
        {
            var result = await _http.DeleteAsync($"api/kvar/{id}");
            _navigationManger.NavigateTo("kvarovi");
        }

        public async Task<Kvarovi?> GetKvarById(int id)
        {
            var result = await _http.GetAsync($"api/kvar/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Kvarovi>();
            }
            return null;
        }

        public async Task GetKvarove()
        {
            var result = await _http.GetFromJsonAsync<List<Kvarovi>>("api/kvar");
            if (result is not null)
                Kvarovis = result;
        }

        public async Task UpdateKvar(int id, Kvarovi kvarovi)
        {
            await _http.PutAsJsonAsync($"api/kvar/{id}", kvarovi);
            _navigationManger.NavigateTo("kvarovi");
        }
    }
}
