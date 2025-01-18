using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSE422_Lab2.Data;
using CSE422_Lab2.Models;

namespace CSE422_Lab2.Controllers
{
    public class DevicesController : Controller
    {
        private readonly CSE422_Lab2Context _context;

        public DevicesController(CSE422_Lab2Context context)
        {
            _context = context;
        }

        // GET: Devices
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeviceModel.ToListAsync());
        }

        // GET: Devices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceModel = await _context.DeviceModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deviceModel == null)
            {
                return NotFound();
            }

            return View(deviceModel);
        }

        // GET: Devices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Devices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Category,Status")] DeviceModel deviceModel)
        {
            if (ModelState.IsValid)
            {
                DeviceModel newDevice = new DeviceModel();
                newDevice.Id = deviceModel.Id;
                newDevice.Name = deviceModel.Name;
                newDevice.Category = deviceModel.Category;
                newDevice.Status = deviceModel.Status;
                newDevice.DateOfEntry = DateTime.Now;
                _context.Add(newDevice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deviceModel);
        }

        // GET: Devices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceModel = await _context.DeviceModel.FindAsync(id);
            if (deviceModel == null)
            {
                return NotFound();
            }
            return View(deviceModel);
        }

        // POST: Devices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Category,Status,DateOfEntry")] DeviceModel deviceModel)
        {
            if (id != deviceModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deviceModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeviceModelExists(deviceModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(deviceModel);
        }

        // GET: Devices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceModel = await _context.DeviceModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deviceModel == null)
            {
                return NotFound();
            }

            return View(deviceModel);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deviceModel = await _context.DeviceModel.FindAsync(id);
            if (deviceModel != null)
            {
                _context.DeviceModel.Remove(deviceModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeviceModelExists(int id)
        {
            return _context.DeviceModel.Any(e => e.Id == id);
        }
    }
}
