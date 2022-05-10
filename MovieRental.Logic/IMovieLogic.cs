// <copyright file="IMovieLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MovieRental.Data;

    /// <summary>
    /// Sets the methods for the MovieLogic class.
    /// </summary>
    public interface IMovieLogic
    {
        /// <summary>
        /// Gets a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <returns>A selected Movie entity.</returns>
        Movie GetOneMovie(int id);

        /// <summary>
        /// Gets a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <returns>A selected Staff entity.</returns>
        Staff GetOneStaff(int id);

        /// <summary>
        /// Gets all of the Movie entities.
        /// </summary>
        /// <returns>A list of all the Movie entities.</returns>
        IList<Movie> GetAllMovies();

        /// <summary>
        /// Gets all of the Staff entities.
        /// </summary>
        /// <returns>A list of all the Staff entities.</returns>
        IList<Staff> GetAllStaffs();

        /// <summary>
        /// Sets a new title for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="title">The title, that gets the Movie entity.</param>
        void ChangeMovieTitle(int id, string title);

        /// <summary>
        /// Sets a new dsitributor for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="distributor">The distributor, that gets the Movie entity.</param>
        void ChangeMovieDistributor(int id, string distributor);

        /// <summary>
        /// Sets a new category for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="category">The category, that gets the Movie entity.</param>
        void ChangeMovieCategory(int id, string category);

        /// <summary>
        /// Sets a new length for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="length">The length, that gets the Movie entity.</param>
        void ChangeMovieLength(int id, string length);

        /// <summary>
        /// Sets a new language for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="language">The language, that gets the Movie entity.</param>
        void ChangeMovieLanguage(int id, string language);

        /// <summary>
        /// Sets a new director for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="director">The director, that gets the Staff entity.</param>
        void ChangeStaffDirector(int id, string director);

        /// <summary>
        /// Sets a new main character for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="mainCharacter">The main character, that gets the Staff entity.</param>
        void ChangeStaffMainCharacter(int id, string mainCharacter);

        /// <summary>
        /// Sets a new number of supporting characters for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="suportingCharacters">The supporting characters, that gets the Staff entity.</param>
        void ChangeStaffSupportingCharacters(int id, int suportingCharacters);

        /// <summary>
        /// Sets a new cost for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="cost">The cost, that gets the Staff entity.</param>
        void ChangeStaffCost(int id, int cost);

        /// <summary>
        /// Sets a new studio for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="studio">The studio, that gets the Staff entity.</param>
        void ChangeStaffStudio(int id, string studio);

        /// <summary>
        /// Deletes a Movie entity.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        void DeleteMovie(int id);

        /// <summary>
        /// Deletes a Staff entity.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        void DeleteStaff(int id);

        /// <summary>
        /// Creates a Movie entity.
        /// </summary>
        /// <param name="title">The title, that gets the Movie entity.</param>
        /// <param name="distributor">The distributor, that gets the Movie entity.</param>
        /// <param name="category">The category, that gets the Movie entity.</param>
        /// <param name="length">The length, that gets the Movie entity.</param>
        /// <param name="language">The language, that gets the Movie entity.</param>
        /// <param name="rentId">The rentId, that gets the Movie entity.</param>
        void CreateMovie(string title, string distributor, string category, string length, string language, int rentId);

        /// <summary>
        /// Creates a Staff entity.
        /// </summary>
        /// <param name="director">The director, that gets the Staff entity.</param>
        /// <param name="mainCharacter">The main character, that gets the Staff entity.</param>
        /// <param name="supportingCharacters">The supporting characters, that gets the Staff entity.</param>
        /// <param name="cost">The cost, that gets the Staff entity.</param>
        /// <param name="studio">The studio, that gets the Staff entity.</param>
        /// <param name="movieId">The movieId, that gets the Staff entity.</param>
        void CreateStaff(string director, string mainCharacter, int supportingCharacters, int cost, string studio, int movieId);

        /// <summary>
        /// Listing the average cost of movies grouped by categories.
        /// </summary>
        /// <returns>A list of average costs.</returns>
        IList<MovieAverageCost> AverageCost();

        /// <summary>
        /// Listing the sum of supporting characters grouped by distributors.
        /// </summary>
        /// <returns>A list of sum of supporting characters.</returns>
        IList<MovieSumCharacternumber> SumCharacternumber();

        /// <summary>
        /// Async task: listing the average cost of movies grouped by categories.
        /// </summary>
        /// <returns>Average costs list in task.</returns>
        Task<IList<MovieAverageCost>> AverageCostAsync();

        /// <summary>
        /// Async task: listing the sum of supporting characters grouped by distributors.
        /// </summary>
        /// <returns>Sum of supporting characters list in task.</returns>
        Task<IList<MovieSumCharacternumber>> SumCharacternumberAsync();
    }
}
