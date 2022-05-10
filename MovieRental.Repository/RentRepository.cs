// <copyright file="RentRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using MovieRental.Data;

    /// <summary>
    /// The rent repository, which sets the methods for the Rent table.
    /// </summary>
    public class RentRepository : MainRepository<Rent>, IRentRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RentRepository"/> class.
        /// </summary>
        /// <param name="ctx">The ctx represents the database.</param>
        public RentRepository(DbContext ctx)
            : base(ctx)
        {
        }

        /// <summary>
        /// Gets a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <returns>A selected Rent entity.</returns>
        public override Rent GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.RentId == id);
        }

        /// <summary>
        /// Sets a new order for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="order">The order, that gets the Rent entity.</param>
        public void ChangeOrder(int id, DateTime order)
        {
            Rent rent = this.GetOne(id);
            rent.Order = order;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new price for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="price">The price, that gets the Rent entity.</param>
        public void ChangePrice(int id, int price)
        {
            Rent rent = this.GetOne(id);
            rent.Price = price;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new start of the rental for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="rentalStart">The start of the rental, that gets the Rent entity.</param>
        public void ChangeRentalStart(int id, DateTime rentalStart)
        {
            Rent rent = this.GetOne(id);
            rent.RentalStart = rentalStart;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new end of the rental for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="rentalEnd">The end of the rental, that gets the Rent entity.</param>
        public void ChangeRentalEnd(int id, DateTime rentalEnd)
        {
            Rent rent = this.GetOne(id);
            rent.RentalEnd = rentalEnd;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new overrun fee for a Rent entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Rent entity.</param>
        /// <param name="overrunFee">The overrun fee, that gets the Rent entity.</param>
        public void ChangeOverrunFee(int id, int overrunFee)
        {
            Rent rent = this.GetOne(id);
            rent.OverrunFee = overrunFee;
            this.Ctx.SaveChanges();
        }
    }
}
