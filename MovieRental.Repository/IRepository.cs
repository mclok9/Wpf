// <copyright file="IRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sets the methods for the repositories.
    /// </summary>
    /// <typeparam name="T">Sets the T(generic type) for a repository.</typeparam>
    public interface IRepository<T>
        where T : class
    {
        /// <summary>
        /// Gets one entity from a table.
        /// </summary>
        /// <param name="id">The id, which indicates the entity.</param>
        /// <returns>A selected(generic) entity.</returns>
        T GetOne(int id);

        /// <summary>
        /// Gets all of the entities from a table.
        /// </summary>
        /// <returns>A list of all the selected(generic) entities.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Creates an entity for a table.
        /// </summary>
        /// <param name="entity">A selected(generic) entity.</param>
        void Create(T entity);

        /// <summary>
        /// Deletes an entity from a table.
        /// </summary>
        /// <param name="entity">A selected(generic) entity.</param>
        void Delete(T entity);
    }
}
