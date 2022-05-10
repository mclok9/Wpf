// <copyright file="StaffRepository.cs" company="PlaceholderCompany">
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
    /// The staff repository, which sets the methods for the Staff table.
    /// </summary>
    public class StaffRepository : MainRepository<Staff>, IStaffRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffRepository"/> class.
        /// </summary>
        /// <param name="ctx">The ctx represents the database.</param>
        public StaffRepository(DbContext ctx)
            : base(ctx)
        {
        }

        /// <summary>
        /// Gets a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <returns>A selected Staff entity.</returns>
        public override Staff GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.StaffId == id);
        }

        /// <summary>
        /// Sets a new director for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="director">The director, that gets the Staff entity.</param>
        public void ChangeDirector(int id, string director)
        {
            Staff staff = this.GetOne(id);
            staff.Director = director;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new main character for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="mainCharacter">The main character, that gets the Staff entity.</param>
        public void ChangeMainCharacter(int id, string mainCharacter)
        {
            Staff staff = this.GetOne(id);
            staff.MainCharacter = mainCharacter;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new number of supporting characters for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="supportingCharacters">The supporting characters, that gets the Staff entity.</param>
        public void ChangeSupportingCharacters(int id, int supportingCharacters)
        {
            Staff staff = this.GetOne(id);
            staff.SupportingCharacters = supportingCharacters;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new cost for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="cost">The cost, that gets the Staff entity.</param>
        public void ChangeCost(int id, int cost)
        {
            Staff staff = this.GetOne(id);
            staff.Cost = cost;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new studio for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="studio">The studio, that gets the Staff entity.</param>
        public void ChangeStudio(int id, string studio)
        {
            Staff staff = this.GetOne(id);
            staff.Studio = studio;
            this.Ctx.SaveChanges();
        }
    }
}
