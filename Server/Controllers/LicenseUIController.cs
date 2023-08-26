using FLN.LicenseManager.Server.Services.LicenseUIService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FLN.LicenseManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseUIController : ControllerBase
    {
        private readonly ILicenseUIService _licenseUIService;

        public LicenseUIController(ILicenseUIService licenseUIService)
        {
            _licenseUIService = licenseUIService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<License>>>> GetLicensesAsync()
        {
            var result = await _licenseUIService.GetLicensesAsync();
            return Ok(result);
        }
    }
}
