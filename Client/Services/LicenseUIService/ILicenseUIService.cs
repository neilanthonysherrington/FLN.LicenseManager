namespace FLN.LicenseManager.Client.Services.LicenseUIService
{
    public interface ILicenseUIService
    {
        List<License> Licenses{ get; set; }
        Task GetLicenses();
    }
}
