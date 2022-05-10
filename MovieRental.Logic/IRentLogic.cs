// <copyright file="IRentLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MovieRental.Data;

    /// <summary>
    /// Sets the methods for the RentLogic class.
    /// </summary>
    public interface IRentLogic
    {
        /// <summary>
        /// Gets a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <returns>A selected Rent entity.</returns>
        Rent GetOneRent(int id);

        /// <summary>
        /// Gets a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <returns>A selected Renter entity.</returns>
        Renter GetOneRenter(int id);

        /// <summary>
        /// Gets all of the Rent entities.
        /// </summary>
        /// <returns>A list of all the Rent entities.</returns>
        IList<Rent> GetAllRents();

        /// <summary>
        /// Gets all of the Renter entities.
        /// </summary>
        /// <returns>A list of all the Renter entities.</returns>
        IList<Renter> GetAllRenters();

        /// <summary>
        /// Sets a new order for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="order">The order, that gets the Rent entity.</param>
        void ChangeRentOrder(int id, DateTime order);

        /// <summary>
        /// Sets a new price for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="price">The price, that gets the Rent entity.</param>
        void ChangeRentPrice(int id, int price);

        /// <summary>
        /// Sets a new start of the rental for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="rentalStart">The start of the rental, that gets the Rent entity.</param>
        void ChangeRentRentalStart(int id, DateTime rentalStart);

        /// <summary>
        /// Sets a new end of the rental for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="rentalEnd">The end of the rental, that gets the Rent entity.</param>
        void ChangeRentRentalEnd(int id, DateTime rentalEnd);

        /// <summary>
        /// Sets a new overrun fee for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="overrunFee">The overrun fee, that gets the Rent entity.</param>
        void ChangeRentOverrunFee(int id, int overrunFee);

        /// <summary>
        /// Sets a new name for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="name">The name, that gets the Renter entity.</param>
        void ChangeRenterName(int id, string name);

        /// <summary>
        /// Sets a new postcode for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="postcode">The postcode, that gets the Renter entity.</param>
        void ChangeRenterPostcode(int id, int postcode);

        /// <summary>
        /// Sets a new city for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="city">The city, that gets the Renter entity.</param>
        void ChangeRenterCity(int id, string city);

        /// <summary>
        /// Sets a new street for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="street">The street, that gets the Renter entity.</param>
        void ChangeRenterStreet(int id, string street);

        /// <summary>
        /// Sets a new house number for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="houseNumber">The house number, that gets the Renter entity.</param>
        void ChangeRenterHouseNumber(int id, string houseNumber);

        /// <summary>
        /// Sets a new start of the membership for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="membershipStart">The start of the membership, that gets the Renter entity.</param>
        void ChangeRenterMembershipStart(int id, DateTime membershipStart);

        /// <summary>
        /// Sets a new end of the membership for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="membershipEnd">The end of the membership, that gets the Renter entity.</param>
        void ChangeRenterMembershipEnd(int id, DateTime membershipEnd);

        /// <summary>
        /// Deletes a Rent entity.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        void DeleteRent(int id);

        /// <summary>
        /// Deletes a Renter entity.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        void DeleteRenter(int id);

        /// <summary>
        /// Creates a Rent entity.
        /// </summary>
        /// <param name="order">The order, that gets the Rent entity.</param>
        /// <param name="price">The price, that gets the Rent entity.</param>
        /// <param name="rentalStart">The start of the rental, that gets the Rent entity.</param>
        /// <param name="rentalEnd">The end of the rental, that gets the Rent entity.</param>
        /// <param name="overrunFee">The overrun fee, that gets the Rent entity.</param>
        void CreateRent(DateTime order, int price, DateTime rentalStart, DateTime rentalEnd, int overrunFee);

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
        void CreateRenter(string name, int postcode, string city, string street, string houseNumber, DateTime membershipStart, DateTime membershipEnd, int rentId);

        /// <summary>
        /// Listing the sum of prices grouped by cities.
        /// </summary>
        /// <returns>A list of sum of prices.</returns>
        IList<RenterSumPrice> SumPrice();

        /// <summary>
        /// Async task: listing the sum of prices grouped by cities.
        /// </summary>
        /// <returns>Sum of prices list in task.</returns>
        Task<IList<RenterSumPrice>> SumPriceAsync();
    }
}
