// <copyright file="IRentRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Repository
{
    using System;
    using System.Collections.Generic;
    using MovieRental.Data;

    /// <summary>
    /// Sets the methods for the RentRepository class.
    /// </summary>
    public interface IRentRepository : IRepository<Rent>
    {
        /// <summary>
        /// Sets a new order for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="order">The order, that gets the Rent entity.</param>
        void ChangeOrder(int id, DateTime order);

        /// <summary>
        /// Sets a new price for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="price">The price, that gets the Rent entity.</param>
        void ChangePrice(int id, int price);

        /// <summary>
        /// Sets a new start of the rental for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="rentalStart">The start of the rental, that gets the Rent entity.</param>
        void ChangeRentalStart(int id, DateTime rentalStart);

        /// <summary>
        /// Sets a new end of the rental for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="rentalEnd">The end of the rental, that gets the Rent entity.</param>
        void ChangeRentalEnd(int id, DateTime rentalEnd);

        /// <summary>
        /// Sets a new overrun fee for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="overrunFee">The overrun fee, that gets the Rent entity.</param>
        void ChangeOverrunFee(int id, int overrunFee);
    }
}
