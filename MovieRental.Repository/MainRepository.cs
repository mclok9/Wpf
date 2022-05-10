// <copyright file="MainRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Repository
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The main repository, which sets the methods for the repositories.
    /// </summary>
    /// <typeparam name="T">T is a generic type, must be a class.</typeparam>
    public abstract class MainRepository<T> : IRepository<T>
        where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainRepository{T}"/> class.
        /// </summary>
        /// <param name="ctx">The ctx represents the database.</param>
        public MainRepository(DbContext ctx)
        {
            this.Ctx = ctx;
        }

        /// <summary>
        /// Gets or sets the database.
        /// </summary>
        public DbContext Ctx { get; set; }

        /// <summary>
        /// Gets an entity from a table.
        /// </summary>
        /// <param name="id">The id, which indicates the entity.</param>
        /// <returns>A selected(generic) entity.</returns>
        public abstract T GetOne(int id);

        /// <summary>
        /// Gets all of the entities from a table.
        /// </summary>
        /// <returns>A list of all the selected(generic) entities.</returns>
        public IQueryable<T> GetAll()
        {
            return this.Ctx.Set<T>();
        }

        /// <summary>
        /// Creates an entity for a table.
        /// </summary>
        /// <param name="entity">A selected(generic) entity.</param>
        public void Create(T entity)
        {
            this.Ctx.Set<T>().Add(entity);
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Deletes an entity from a table.
        /// </summary>
        /// <param name="entity">A selected(generic) entity.</param>
        public void Delete(T entity)
        {
            this.Ctx.Set<T>().Remove(entity);
            this.Ctx.SaveChanges();
        }
    }
}
