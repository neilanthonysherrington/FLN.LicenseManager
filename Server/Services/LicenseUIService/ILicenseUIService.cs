namespace FLN.LicenseManager.Server.Services.LicenseUIService
{
    public interface ILicenseUIService
    {
        Task<ServiceResponse<List<License>>> GetLicensesAsync();
        //Task<ServiceResponse<License>> GetLicenseAsync(int id);
        //Task<ServiceResponse<License>> AddLicenseAsync(License license);
        //Task<ServiceResponse<License>> AddExistingLicenseAsync(License license);
        //Task<ServiceResponse<License>> UpdateLicenseAsync(License license);
        //Task<ServiceResponse<License>> DeleteLicenseAsync(int id);
    }
}
