using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicineProj.Models;
using Microsoft.AspNetCore.Authorization;
using MedicineProj.Repository;

namespace MedicineProj.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(MedicinesController));
        //private readonly pharmacy_dbContext _context;

        //public MedicinesController(pharmacy_dbContext context)
        //{
        //    _context = context;
        //}
        private readonly IMedicineRepository _medicineRepository;
        public MedicinesController(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }
        /* public MedicinesController()
         {
         }
        */
        // GET: api/Medicines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicine>>> GetMedicine()
        {
            _log4net.Info("Controller of Medicines Project");
            return Ok(_medicineRepository.GetMedicine());
        }

        // GET: api/Medicines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medicine>> GetMedicine(int id)
        {
            return Ok(_medicineRepository.GetMedicine(id));
        }

        // PUT: api/Medicines/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicine(int id, Medicine medicine)
        {
            if (id != medicine.MedicineId)
            {
                return BadRequest();
            }
            _medicineRepository.PutMedicine(id, medicine);
            return NoContent();
        }

        // POST: api/Medicines
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Medicine>> PostMedicine(Medicine medicine)
        {
            _medicineRepository.PostMedicine(medicine);
            return CreatedAtAction("GetMedicine", new { id = medicine.MedicineId }, medicine);
        }

        // DELETE: api/Medicines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Medicine>> DeleteMedicine(int id)
        {
            IQueryable<Medicine> medicines = (IQueryable<Medicine>)_medicineRepository.DeleteMedicine(id);
            if (medicines.Count() == 0)
            {
                return NotFound();
            }

            return Ok(medicines);
        }

    }
}
