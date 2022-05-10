// <copyright file="RenterRepository.cs" company="PlaceholderCompany">
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
    /// The renter repository, which sets the methods for the Renter table.
    /// </summary>
    public class RenterRepository : MainRepository<Renter>, IRenterRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenterRepository"/> class.
        /// </summary>
        /// <param name="ctx">The ctx represents the database.</param>
        public RenterRepository(DbContext ctx)
            : base(ctx)
        {
        }

        /// <summary>
        /// Gets a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <returns>A selected Renter entity.</returns>
        public override Renter GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.RenterId == id);
        }

        /// <summary>
        /// Sets a new name for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="name">The title, that gets the Renter entity.</param>
        public void ChangeName(int id, string name)
        {
            Renter renter = this.GetOne(id);
            renter.Name = name;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new postcode for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="postcode">The postcode, that gets the Renter entity.</param>
        public void ChangePostcode(int id, int postcode)
        {
            Renter renter = this.GetOne(id);
            renter.Postcode = postcode;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new city for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="city">The city, that gets the Renter entity.</param>
        public void ChangeCity(int id, string city)
        {
            Renter renter = this.GetOne(id);
            renter.City = city;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new street for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="street">The street, that gets the Renter entity.</param>
        public void ChangeStreet(int id, string street)
        {
            Renter renter = this.GetOne(id);
            renter.Street = street;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new house number for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="houseNumber">The house number, that gets the Renter entity.</param>
        public void ChangeHouseNumber(int id, string houseNumber)
        {
            Renter renter = this.GetOne(id);
            renter.HouseNumber = houseNumber;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new start of the membership for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="membershipStart">The start of the membership, that gets the Renter entity.</param>
        public void ChangeMembershipStart(int id, DateTime membershipStart)
        {
            Renter renter = this.GetOne(id);
            renter.MembershipStart = membershipStart;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new end of the membership for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="membershipEnd">The end of the membership, that gets the Renter entity.</param>
        public void ChangeMembershipEnd(int id, DateTime membershipEnd)
        {
            Renter renter = this.GetOne(id);
            renter.MembershipEnd = membershipEnd;
            this.Ctx.SaveChanges();
        }
    }
}
