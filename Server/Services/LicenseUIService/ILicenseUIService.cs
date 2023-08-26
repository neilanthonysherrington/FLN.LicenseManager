namespace FLN.LicenseManager.Server.Services.LicenseUIService
{
    public interface ILicenseUIService
    {
        Task<ServiceResponse<List<License>>> GetLicensesAsync();
    }
}
