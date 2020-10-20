using MedicineProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineProj.Repository
{
    public interface IMedicineRepository
    {
        public List<Medicine> GetMedicine();
        public IQueryable<Medicine> GetMedicine(int id);
        public Medicine PutMedicine(int id, Medicine medicine);
        public void PostMedicine(Medicine medicine);
        public IQueryable<Medicine> DeleteMedicine(int id);
    }
}
