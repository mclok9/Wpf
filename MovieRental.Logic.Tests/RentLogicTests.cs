// <copyright file="RentLogicTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Moq;
    using MovieRental.Data;
    using MovieRental.Repository;
    using NUnit.Framework;

    /// <summary>
    /// Class contains the RentLogic for CRUD and non-CRUD logic tests.
    /// </summary>
    [TestFixture]
    public class RentLogicTests
    {
        private Mock<IRentRepository> mockedRentRepository;
        private Mock<IRenterRepository> mockedRenterRepository;
        private List<RenterSumPrice> mockedSumPrice;
        private List<Rent> rents;

        /// <summary>
        /// Testing the working of GetOneRent(int id) method.
        /// </summary>
        /// <param name="id">Adding the id to the mockedRentRepository.</param>
        [TestCase(0)]
        [TestCase(2)]
        public void TestGetOneRent(int id)
        {
            var logic = this.CreateRentLogicMock();
            this.mockedRentRepository.Setup(repository => repository.GetOne(It.Is<int>(id => id >= 0 && id <= this.rents.Count))).Returns(this.rents[id]);

            var result = logic.GetOneRent(id);

            this.mockedRentRepository.Verify(x => x.GetOne(id), Times.Exactly(1));
            this.mockedRentRepository.Verify(x => x.GetAll(), Times.Never);
        }

        /// <summary>
        /// Testing the working of GetAllRents() method.
        /// </summary>
        [Test]
        public void TestGetAllRents()
        {
            var logic = this.CreateRentLogicMock();

            var result = logic.GetAllRents();

            this.mockedRentRepository.Verify(x => x.GetAll(), Times.Once);
        }

        /// <summary>
        /// Testing the working of DeleteRent(int id) method.
        /// </summary>
        /// <param name="id">Adding the id to the mockedRentRepository.</param>
        [TestCase(1)]
        [TestCase(2)]
        public void TestDeleteRent(int id)
        {
            var logic = this.CreateRentLogicMock();

            logic.DeleteRent(id);

            this.mockedRentRepository.Verify(x => x.GetOne(id), Times.Once);
        }

        /// <summary>
        /// Testing the working of DeleteRent(int id) method with a wrong id.
        /// </summary>
        /// <param name="id">Adding the id to the mockedRentRepository.</param>
        [TestCase(-1)]
        public void TestDeleteRentWrongId(int id)
        {
            var logic = this.CreateRentLogicMock();

            logic.DeleteRent(id);

            this.mockedRentRepository.Verify(x => x.GetOne(id), Times.Once);
        }

        /// <summary>
        /// Testing the working of CreateRent(DateTime order, int price, DateTime rentalStart, DateTime rentalEnd, int overrunFee) method.
        /// </summary>
        [Test]
        public void TestCreateRent()
        {
            var logic = this.CreateRentLogicMock();
            this.mockedRentRepository.Setup(repository => repository.Create(It.IsAny<Rent>())).Verifiable();

            logic.CreateRent(DateTime.Parse("2020, 05, 21", null), 1800, DateTime.Parse("2020, 07, 14", null), DateTime.Parse("2020, 08, 20", null), 600);

            this.mockedRentRepository.Verify(repository => repository.Create(It.IsAny<Rent>()), Times.Once);
        }

        /// <summary>
        /// Testing the working of CreateRent(DateTime order, int price, DateTime rentalStart, DateTime rentalEnd, int overrunFee) method with an existing entity.
        /// </summary>
        [Test]
        public void TestCreateRentExistingEntity()
        {
            var logic = this.CreateRentLogicMock();
            this.mockedRentRepository.Setup(repository => repository.Create(It.IsAny<Rent>())).Verifiable();

            Rent testRent = new Rent()
            {
                Order = DateTime.Parse("2020, 05, 21", null),
                Price = 1800,
                RentalStart = DateTime.Parse("2020, 07, 14", null),
                RentalEnd = DateTime.Parse("2020, 08, 20", null),
                OverrunFee = 600,
            };

            logic.CreateRent(testRent.Order, testRent.Price, testRent.RentalStart, testRent.RentalEnd, testRent.OverrunFee);

            this.mockedRentRepository.Verify(repository => repository.Create(testRent), Times.Never);
        }

        /// <summary>
        /// Testing the working of SumPrice() method.
        /// </summary>
        [Test]
        public void TestRenterSumPrice()
        {
            var logic = this.CreateRentLogicMock();
            var value = logic.SumPrice();

            Assert.That(value, Is.EquivalentTo(this.mockedSumPrice));

            this.mockedRentRepository.Verify(repository => repository.GetAll(), Times.Once);
            this.mockedRenterRepository.Verify(repository => repository.GetAll(), Times.Once);
        }

        private RentLogic CreateRentLogicMock()
        {
            this.mockedRentRepository = new Mock<IRentRepository>();
            this.mockedRenterRepository = new Mock<IRenterRepository>();

            Rent elso = new Rent() { RentId = 1, Order = new DateTime(2020, 02, 24), Price = 2000, RentalStart = new DateTime(2020, 02, 26), RentalEnd = new DateTime(2020, 03, 26), OverrunFee = 800 };
            Rent masodik = new Rent() { RentId = 2, Order = new DateTime(2020, 08, 15), Price = 3100, RentalStart = new DateTime(2020, 01, 10), RentalEnd = new DateTime(2020, 02, 20), OverrunFee = 1100 };
            Rent harmadik = new Rent() { RentId = 3, Order = new DateTime(2020, 05, 03), Price = 1300, RentalStart = new DateTime(2020, 04, 11), RentalEnd = new DateTime(2020, 06, 17), OverrunFee = 1900 };

            this.rents = new List<Rent>() { elso, masodik, harmadik };

            List<Renter> renters = new List<Renter>()
            {
                new Renter() { RenterId = 1, Name = "Vékony Gyula", Postcode = 1227, City = "Budapest", Street = "Liliom", HouseNumber = "15", MembershipStart = new DateTime(2019, 03, 23), MembershipEnd = new DateTime(2020, 11, 23), RentId = elso.RentId },
                new Renter() { RenterId = 2, Name = "Horvát János", Postcode = 4007, City = "Debrecen", Street = "Kapu", HouseNumber = "3", MembershipStart = new DateTime(2019, 06, 23), MembershipEnd = new DateTime(2020, 10, 23), RentId = masodik.RentId },
                new Renter() { RenterId = 3, Name = "Virág Aladár", Postcode = 4021, City = "Debrecen", Street = "Oroszlán", HouseNumber = "31", MembershipStart = new DateTime(2019, 01, 12), MembershipEnd = new DateTime(2020, 06, 11), RentId = harmadik.RentId },
            };

            this.mockedSumPrice = new List<RenterSumPrice>()
            {
                new RenterSumPrice() { City = "Budapest", Price = 2000 },
                new RenterSumPrice() { City = "Debrecen", Price = 4400 },
            };

            this.mockedRentRepository.Setup(repository => repository.GetAll()).Returns(this.rents.AsQueryable());
            this.mockedRenterRepository.Setup(repository => repository.GetAll()).Returns(renters.AsQueryable());

            return new RentLogic(this.mockedRentRepository.Object, this.mockedRenterRepository.Object);
        }
    }
}
