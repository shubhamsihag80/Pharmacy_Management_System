using NUnit.Framework;
using MedicineProj.Controllers;
using MedicineProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Microsoft.EntityFrameworkCore;
using MedicineProj.Repository;

namespace MedicineUnitTesting
{
    public class Tests
    {
        public List<Medicine> meds = new List<Medicine>();
        
        IQueryable<Medicine> medicinedata;
        Mock<DbSet<Medicine>> mockSet;
        Mock<pharmacy_dbContext> medicinecontextmock;
        [SetUp]
        public void Setup()
        {

            meds = new List<Medicine>()
            {

                new Medicine{MedicineId = 653, MedicineName = "ONMUSCLE", ExpiryDate = new DateTime(2021,10,25)},
                new Medicine{MedicineId = 655, MedicineName = "MUSCLEGAIN", ExpiryDate = new DateTime(2021,08,15)}

            };
            medicinedata = meds.AsQueryable();
            mockSet = new Mock<DbSet<Medicine>>();
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.Provider).Returns(medicinedata.Provider);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.Expression).Returns(medicinedata.Expression);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.ElementType).Returns(medicinedata.ElementType);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.GetEnumerator()).Returns(medicinedata.GetEnumerator());
            var p = new DbContextOptions<pharmacy_dbContext>();
            medicinecontextmock = new Mock<pharmacy_dbContext>(p);
            medicinecontextmock.Setup(x => x.Medicine).Returns(mockSet.Object);

        }
        [Test]
        public void Test1()
        {
            var medicineService = new MedicineRepository(medicinecontextmock.Object);
            var medicinelist = medicineService.GetMedicine(655);
            Assert.AreEqual(1, medicinelist.Count());
        }
        [Test]
        public void Test2()
        {
            var medicineService = new MedicineRepository(medicinecontextmock.Object);
            var x = medicineService.DeleteMedicine(653);
            Assert.IsNotNull(x);
        }
    }
}