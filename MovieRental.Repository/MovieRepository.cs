// <copyright file="MovieRepository.cs" company="PlaceholderCompany">
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
    /// The movie repository, which sets the methods for the Movie table.
    /// </summary>
    public class MovieRepository : MainRepository<Movie>, IMovieRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieRepository"/> class.
        /// </summary>
        /// <param name="ctx">The ctx represents the database.</param>
        public MovieRepository(DbContext ctx)
            : base(ctx)
        {
        }

        /// <summary>
        /// Gets a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <returns>A selected Movie entity.</returns>
        public override Movie GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.MovieId == id);
        }

        /// <summary>
        /// Sets a new title for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="title">The title, that gets the Movie entity.</param>
        public void ChangeTitle(int id, string title)
        {
            Movie movie = this.GetOne(id);
            movie.Title = title;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new distributor for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="distributor">The distributor, that gets the Movie entity.</param>
        public void ChangeDistributor(int id, string distributor)
        {
            Movie movie = this.GetOne(id);
            movie.Distributor = distributor;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new category for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="category">The category, that gets the Movie entity.</param>
        public void ChangeCategory(int id, string category)
        {
            Movie movie = this.GetOne(id);
            movie.Category = category;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new length for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="length">The length, that gets the Movie entity.</param>
        public void ChangeLength(int id, string length)
        {
            Movie movie = this.GetOne(id);
            movie.Length = length;
            this.Ctx.SaveChanges();
        }

        /// <summary>
        /// Sets a new language for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="language">The language, that gets the Movie entity.</param>
        public void ChangeLanguage(int id, string language)
        {
            Movie movie = this.GetOne(id);
            movie.Language = language;
            this.Ctx.SaveChanges();
        }
    }
}
