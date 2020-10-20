using MedicineProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineProj.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly pharmacy_dbContext _context;

        public MedicineRepository(pharmacy_dbContext context)
        {
            _context = context;
        }
        public IQueryable<Medicine> DeleteMedicine(int id)
        {
            IQueryable<Medicine> medicines = _context.Medicine.Where(a => a.MedicineId == id);
            _context.Medicine.Remove(medicines.FirstOrDefault());
            _context.SaveChangesAsync();
            return medicines;
        }

        public List<Medicine> GetMedicine()
        {
            return _context.Medicine.ToList();
        }

        public IQueryable<Medicine> GetMedicine(int id)
        {
            return _context.Medicine.Where(a => a.MedicineId == id);
        }

        public void PostMedicine(Medicine medicine)
        {
            _context.Medicine.Add(medicine);
            _context.SaveChangesAsync();
        }

        public Medicine PutMedicine(int id, Medicine medicine)
        {
            _context.Entry(medicine).State = EntityState.Modified;
            _context.SaveChangesAsync();
            return medicine;
        }
    }
}
