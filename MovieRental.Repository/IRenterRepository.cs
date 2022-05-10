// <copyright file="IRenterRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Repository
{
    using System;
    using System.Collections.Generic;
    using MovieRental.Data;

    /// <summary>
    /// Sets the methods for the RenterRepository class.
    /// </summary>
    public interface IRenterRepository : IRepository<Renter>
    {
        /// <summary>
        /// Sets a new name for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="name">The title, that gets the Renter entity.</param>
        void ChangeName(int id, string name);

        /// <summary>
        /// Sets a new postcode for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="postcode">The postcode, that gets the Renter entity.</param>
        void ChangePostcode(int id, int postcode);

        /// <summary>
        /// Sets a new city for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="city">The city, that gets the Renter entity.</param>
        void ChangeCity(int id, string city);

        /// <summary>
        /// Sets a new street for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="street">The street, that gets the Renter entity.</param>
        void ChangeStreet(int id, string street);

        /// <summary>
        /// Sets a new house number for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="houseNumber">The house number, that gets the Renter entity.</param>
        void ChangeHouseNumber(int id, string houseNumber);

        /// <summary>
        /// Sets a new start of the membership for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="membershipStart">The start of the membership, that gets the Renter entity.</param>
        void ChangeMembershipStart(int id, DateTime membershipStart);

        /// <summary>
        /// Sets a new end of the membership for a Renter entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Renter entity.</param>
        /// <param name="membershipEnd">The end of the membership, that gets the Renter entity.</param>
        void ChangeMembershipEnd(int id, DateTime membershipEnd);
    }
}
