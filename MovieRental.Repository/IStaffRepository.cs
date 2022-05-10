// <copyright file="IStaffRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Repository
{
    using System;
    using System.Collections.Generic;
    using MovieRental.Data;

    /// <summary>
    /// Sets the methods for the StaffRepository class.
    /// </summary>
    public interface IStaffRepository : IRepository<Staff>
    {
        /// <summary>
        /// Sets a new director for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="director">The director, that gets the Staff entity.</param>
        void ChangeDirector(int id, string director);

        /// <summary>
        /// Sets a new main character for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="mainCharacter">The main character, that gets the Staff entity.</param>
        void ChangeMainCharacter(int id, string mainCharacter);

        /// <summary>
        /// Sets a new number of supporting characters for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="suportingCharacters">The supporting characters, that gets the Staff entity.</param>
        void ChangeSupportingCharacters(int id, int suportingCharacters);

        /// <summary>
        /// Sets a new cost for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="cost">The cost, that gets the Staff entity.</param>
        void ChangeCost(int id, int cost);

        /// <summary>
        /// Sets a new studio for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="studio">The studio, that gets the Staff entity.</param>
        void ChangeStudio(int id, string studio);
    }
}
