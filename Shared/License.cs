namespace FLN.LicenseManager.Shared
{
    public class License
    {
        public int Id { get; set; }
        public string Customer { get; set; } = string.Empty;
        public string Application { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime ExpiryDate { get; set; }
        public string LicenseKey { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
