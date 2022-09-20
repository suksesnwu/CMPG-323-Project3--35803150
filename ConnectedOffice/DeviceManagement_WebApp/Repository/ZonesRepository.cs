using DeviceManagement_WebApp.Data;
using Microsoft.AspNetCore.Mvc;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public class ZonesRepository
    {
        private readonly ConnectedOfficeContext _context;

        // GET: Categories
        public List<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }

        // GET: Categories/Details/5
        public async Task<Zone> GetById(Guid? id)
        {
            var zone = await _context.Zone
                .FirstOrDefaultAsync(m => m.ZoneId == id);

            return (zone);
        }
    }
}
