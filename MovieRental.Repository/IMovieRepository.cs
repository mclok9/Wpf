// <copyright file="IMovieRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Repository
{
    using System;
    using System.Collections.Generic;
    using MovieRental.Data;

    /// <summary>
    /// Sets the methods for the MovieRepository class.
    /// </summary>
    public interface IMovieRepository : IRepository<Movie>
    {
        /// <summary>
        /// Sets a new title for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="title">The title, that gets the Movie entity.</param>
        void ChangeTitle(int id, string title);

        /// <summary>
        /// Sets a new distributor for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="distributor">The distributor, that gets the Movie entity.</param>
        void ChangeDistributor(int id, string distributor);

        /// <summary>
        /// Sets a new category for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="category">The category, that gets the Movie entity.</param>
        void ChangeCategory(int id, string category);

        /// <summary>
        /// Sets a new length for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="length">The length, that gets the Movie entity.</param>
        void ChangeLength(int id, string length);

        /// <summary>
        /// Sets a new language for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="language">The language, that gets the Movie entity.</param>
        void ChangeLanguage(int id, string language);
    }
}
