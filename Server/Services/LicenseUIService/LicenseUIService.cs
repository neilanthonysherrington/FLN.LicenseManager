﻿using FLN.LicenseManager.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace FLN.LicenseManager.Server.Services.LicenseUIService
{
    public class LicenseUIService : ILicenseUIService
    {
        private readonly DataContext _dataContext;

        public LicenseUIService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<License>>> GetLicensesAsync()
        {
            var response = new ServiceResponse<List<License>>
            {
                Data = await _dataContext.Licenses.ToListAsync()
            };

            return response;
        }
    }
}
