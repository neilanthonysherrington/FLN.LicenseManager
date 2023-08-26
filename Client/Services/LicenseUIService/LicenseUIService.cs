using System.Net.Http.Json;

namespace FLN.LicenseManager.Client.Services.LicenseUIService
{
    public class LicenseUIService : ILicenseUIService
    {
        private readonly HttpClient _http;

        public LicenseUIService(HttpClient http)
        {
            _http = http;
        }
        public List<License> Licenses { get; set; } = new List<License>();

        public async Task GetLicenses()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<License>>>("api/licenseui");
            if (result != null && result.Data != null)
            {
                Licenses = result.Data;
            }
        }
    }
}
