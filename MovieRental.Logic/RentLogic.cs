// <copyright file="RentLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using MovieRental.Data;
    using MovieRental.Repository;

    /// <summary>
    /// Rent Logic contains the methods for the Rent and Renter repository.
    /// </summary>
    public class RentLogic : IRentLogic
    {
        private IRentRepository rentRepository;

        private IRenterRepository renterRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentLogic"/> class.
        /// </summary>
        /// <param name="rentRepository">A Rent repository entity.</param>
        /// <param name="renterRepository">A Renter repository entity.</param>
        public RentLogic(IRentRepository rentRepository, IRenterRepository renterRepository)
        {
            this.rentRepository = rentRepository;
            this.renterRepository = renterRepository;
        }

        /// <summary>
        /// Gets a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <returns>A selected Rent entity.</returns>
        public Rent GetOneRent(int id)
        {
            return this.rentRepository.GetOne(id);
        }

        /// <summary>
        /// Gets a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <returns>A selected Renter entity.</returns>
        public Renter GetOneRenter(int id)
        {
            return this.renterRepository.GetOne(id);
        }

        /// <summary>
        /// Gets all of the Rent entities.
        /// </summary>
        /// <returns>A list of all the Rent entities.</returns>
        public IList<Rent> GetAllRents()
        {
            return this.rentRepository.GetAll().ToList();
        }

        /// <summary>
        /// Gets all of the Renter entities.
        /// </summary>
        /// <returns>A list of all the Renter entities.</returns>
        public IList<Renter> GetAllRenters()
        {
            return this.renterRepository.GetAll().ToList();
        }

        /// <summary>
        /// Sets a new order for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="order">The order, that gets the Rent entity.</param>
        public void ChangeRentOrder(int id, DateTime order)
        {
            this.rentRepository.ChangeOrder(id, order);
        }

        /// <summary>
        /// Sets a new price for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="price">The price, that gets the Rent entity.</param>
        public void ChangeRentPrice(int id, int price)
        {
            this.rentRepository.ChangePrice(id, price);
        }

        /// <summary>
        /// Sets a new start of the rental for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="rentalStart">The start of the rental, that gets the Rent entity.</param>
        public void ChangeRentRentalStart(int id, DateTime rentalStart)
        {
            this.rentRepository.ChangeRentalStart(id, rentalStart);
        }

        /// <summary>
        /// Sets a new end of the rental for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="rentalEnd">The end of the rental, that gets the Rent entity.</param>
        public void ChangeRentRentalEnd(int id, DateTime rentalEnd)
        {
            this.rentRepository.ChangeRentalEnd(id, rentalEnd);
        }

        /// <summary>
        /// Sets a new overrun fee for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="overrunFee">The overrun fee, that gets the Rent entity.</param>
        public void ChangeRentOverrunFee(int id, int overrunFee)
        {
            this.rentRepository.ChangeOverrunFee(id, overrunFee);
        }

        /// <summary>
        /// Sets a new name for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="name">The name, that gets the Renter entity.</param>
        public void ChangeRenterName(int id, string name)
        {
            this.renterRepository.ChangeName(id, name);
        }

        /// <summary>
        /// Sets a new postcode for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="postcode">The postcode, that gets the Renter entity.</param>
        public void ChangeRenterPostcode(int id, int postcode)
        {
            this.renterRepository.ChangePostcode(id, postcode);
        }

        /// <summary>
        /// Sets a new city for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="city">The city, that gets the Renter entity.</param>
        public void ChangeRenterCity(int id, string city)
        {
            this.renterRepository.ChangeCity(id, city);
        }

        /// <summary>
        /// Sets a new street for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="street">The street, that gets the Renter entity.</param>
        public void ChangeRenterStreet(int id, string street)
        {
            this.renterRepository.ChangeStreet(id, street);
        }

        /// <summary>
        /// Sets a new house number for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="houseNumber">The house number, that gets the Renter entity.</param>
        public void ChangeRenterHouseNumber(int id, string houseNumber)
        {
            this.renterRepository.ChangeHouseNumber(id, houseNumber);
        }

        /// <summary>
        /// Sets a new start of the membership for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="membershipStart">The start of the membership, that gets the Renter entity.</param>
        public void ChangeRenterMembershipStart(int id, DateTime membershipStart)
        {
            this.renterRepository.ChangeMembershipStart(id, membershipStart);
        }

        /// <summary>
        /// Sets a new end of the membership for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="membershipEnd">The end of the membership, that gets the Renter entity.</param>
        public void ChangeRenterMembershipEnd(int id, DateTime membershipEnd)
        {
            this.renterRepository.ChangeMembershipEnd(id, membershipEnd);
        }

        /// <summary>
        /// Deletes a Rent entity.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        public void DeleteRent(int id)
        {
            this.rentRepository.Delete(this.rentRepository.GetOne(id));
        }

        /// <summary>
        /// Deletes a Renter entity.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        public void DeleteRenter(int id)
        {
            this.renterRepository.Delete(this.renterRepository.GetOne(id));
        }

        /// <summary>
        /// Creates a Rent entity.
        /// </summary>
        /// <param name="order">The order, that gets the Rent entity.</param>
        /// <param name="price">The price, that gets the Rent entity.</param>
        /// <param name="rentalStart">The start of the rental, that gets the Rent entity.</param>
        /// <param name="rentalEnd">The end of the rental, that gets the Rent entity.</param>
        /// <param name="overrunFee">The overrun fee, that gets the Rent entity.</param>
        public void CreateRent(DateTime order, int price, DateTime rentalStart, DateTime rentalEnd, int overrunFee)
        {
            Rent newRent = new Rent
            {
                Order = order,
                Price = price,
                RentalStart = rentalStart,
                RentalEnd = rentalEnd,
                OverrunFee = overrunFee,
            };

            this.rentRepository.Create(newRent);
        }

        /// <summary>
        /// Creates a Renter entity.
        /// </summary>
        /// <param name="name">The name, that gets the Renter entity.</param>
        /// <param name="postcode">The postcode, that gets the Renter entity.</param>
        /// <param name="city">The city, that gets the Renter entity.</param>
        /// <param name="street">The street, that gets the Renter entity.</param>
        /// <param name="houseNumber">The house number, that gets the Renter entity.</param>
        /// <param name="membershipStart">The start of the membership, that gets the Renter entity.</param>
        /// <param name="membershipEnd">The end of the membership, that gets the Renter entity.</param>
        /// <param name="rentId">The rentId, that gets the Renter entity.</param>
        public void CreateRenter(string name, int postcode, string city, string street, string houseNumber, DateTime membershipStart, DateTime membershipEnd, int rentId)
        {
            Renter newRenter = new Renter
            {
                Name = name,
                Postcode = postcode,
                City = city,
                Street = street,
                HouseNumber = houseNumber,
                MembershipStart = membershipStart,
                MembershipEnd = membershipEnd,
                RentId = rentId,
            };

            this.renterRepository.Create(newRenter);
        }

        /// <summary>
        /// Listing the sum of prices grouped by cities.
        /// </summary>
        /// <returns>A list of sum of prices.</returns>
        public IList<RenterSumPrice> SumPrice()
        {
            var q = from renter in this.renterRepository.GetAll()
                    join rent in this.rentRepository.GetAll() on renter.RentId equals rent.RentId
                    let cities = new { City = renter.City, Price = rent.Price }
                    group cities by cities.City into grp
                    select new RenterSumPrice()
                    { City = grp.Key, Price = grp.Sum(renter => renter.Price) };

            return q.ToList();
        }

        /// <summary>
        /// Async task: listing the sum of prices grouped by cities.
        /// </summary>
        /// <returns>Sum of prices list in task.</returns>
        public Task<IList<RenterSumPrice>> SumPriceAsync()
        {
            return Task.Run(() => this.SumPrice());
        }
    }
}
