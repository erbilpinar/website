using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MMS.Data;
using MMS.Models;

namespace MMS.Controllers
{
    public class SoftwareController : Controller
    {
        private readonly SoftwareContext _context;

        public SoftwareController(SoftwareContext context)
        {
            _context = context;
        }

        // GET: Software
        public async Task<IActionResult> Index()
        {
            return View(await _context.Software.ToListAsync());
        }

        // GET: Software/Details/5
        [HttpGet("Details/{id}")] 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var software = await _context.Software
                .FirstOrDefaultAsync(m => m.Id == id);
            string name = software.Name;
            if (software == null)
            {
                return NotFound();
            }

            return View(software);
        }

        private bool SoftwareExists(int id)
        {
            return _context.Software.Any(e => e.Id == id);
        }
    }
}
