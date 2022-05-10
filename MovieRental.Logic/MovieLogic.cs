// <copyright file="MovieLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using MovieRental.Data;
    using MovieRental.Repository;

    /// <summary>
    /// Movie Logic contains the methods for the Movie and Staff repository.
    /// </summary>
    public class MovieLogic : IMovieLogic
    {
        private IMovieRepository movieRepository;

        private IStaffRepository staffRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieLogic"/> class.
        /// </summary>
        /// <param name="movieRepository">A Movie repository entity.</param>
        /// <param name="staffRepository">A Staff repository entity.</param>
        public MovieLogic(IMovieRepository movieRepository, IStaffRepository staffRepository)
        {
            this.movieRepository = movieRepository;
            this.staffRepository = staffRepository;
        }

        /// <summary>
        /// Gets a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <returns>A selected Movie entity.</returns>
        public Movie GetOneMovie(int id)
        {
            return this.movieRepository.GetOne(id);
        }

        /// <summary>
        /// Gets a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <returns>A selected Staff entity.</returns>
        public Staff GetOneStaff(int id)
        {
            return this.staffRepository.GetOne(id);
        }

        /// <summary>
        /// Gets all of the Movie entities.
        /// </summary>
        /// <returns>A list of all the Movie entities.</returns>
        public IList<Movie> GetAllMovies()
        {
            return this.movieRepository.GetAll().ToList();
        }

        /// <summary>
        /// Gets all of the Staff entities.
        /// </summary>
        /// <returns>A list of all the Staff entities.</returns>
        public IList<Staff> GetAllStaffs()
        {
            return this.staffRepository.GetAll().ToList();
        }

        /// <summary>
        /// Sets a new title for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="title">The title, that gets the Movie entity.</param>
        public void ChangeMovieTitle(int id, string title)
        {
            this.movieRepository.ChangeTitle(id, title);
        }

        /// <summary>
        /// Sets a new distributor for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="distributor">The distributor, that gets the Movie entity.</param>
        public void ChangeMovieDistributor(int id, string distributor)
        {
            this.movieRepository.ChangeDistributor(id, distributor);
        }

        /// <summary>
        /// Sets a new category for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="category">The category, that gets the Movie entity.</param>
        public void ChangeMovieCategory(int id, string category)
        {
            this.movieRepository.ChangeCategory(id, category);
        }

        /// <summary>
        /// Sets a new length for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="length">The length, that gets the Movie entity.</param>
        public void ChangeMovieLength(int id, string length)
        {
            this.movieRepository.ChangeLength(id, length);
        }

        /// <summary>
        /// Sets a new language for a Movie entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        /// <param name="language">The language, that gets the Movie entity.</param>
        public void ChangeMovieLanguage(int id, string language)
        {
            this.movieRepository.ChangeLanguage(id, language);
        }

        /// <summary>
        /// Sets a new director for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="director">The director, that gets the Staff entity.</param>
        public void ChangeStaffDirector(int id, string director)
        {
            this.staffRepository.ChangeDirector(id, director);
        }

        /// <summary>
        /// Sets a new main character for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="mainCharacter">The main character, that gets the Staff entity.</param>
        public void ChangeStaffMainCharacter(int id, string mainCharacter)
        {
            this.staffRepository.ChangeMainCharacter(id, mainCharacter);
        }

        /// <summary>
        /// Sets a new number of supporting characters for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="suportingCharacters">The supporting characters, that gets the Staff entity.</param>
        public void ChangeStaffSupportingCharacters(int id, int suportingCharacters)
        {
            this.staffRepository.ChangeSupportingCharacters(id, suportingCharacters);
        }

        /// <summary>
        /// Sets a new cost for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="cost">The cost, that gets the Staff entity.</param>
        public void ChangeStaffCost(int id, int cost)
        {
            this.staffRepository.ChangeCost(id, cost);
        }

        /// <summary>
        /// Sets a new studio for a Staff entity by id.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        /// <param name="studio">The studio, that gets the Staff entity.</param>
        public void ChangeStaffStudio(int id, string studio)
        {
            this.staffRepository.ChangeStudio(id, studio);
        }

        /// <summary>
        /// Deletes a Movie entity.
        /// </summary>
        /// <param name="id">The id, which indicates the Movie entity.</param>
        public void DeleteMovie(int id)
        {
            this.movieRepository.Delete(this.movieRepository.GetOne(id));
        }

        /// <summary>
        /// Deletes a Staff entity.
        /// </summary>
        /// <param name="id">The id, which indicates the Staff entity.</param>
        public void DeleteStaff(int id)
        {
            this.staffRepository.Delete(this.staffRepository.GetOne(id));
        }

        /// <summary>
        /// Creates a Movie entity.
        /// </summary>
        /// <param name="title">The title, that gets the Movie entity.</param>
        /// <param name="distributor">The distributor, that gets the Movie entity.</param>
        /// <param name="category">The category, that gets the Movie entity.</param>
        /// <param name="length">The length, that gets the Movie entity.</param>
        /// <param name="language">The language, that gets the Movie entity.</param>
        /// <param name="rentId">The rentId, that gets the Movie entity.</param>
        public void CreateMovie(string title, string distributor, string category, string length, string language, int rentId)
        {
            Movie newMovie = new Movie
            {
                Title = title,
                Distributor = distributor,
                Category = category,
                Length = length,
                Language = language,
                RentId = rentId,
            };

            this.movieRepository.Create(newMovie);
        }

        /// <summary>
        /// Creates a Staff entity.
        /// </summary>
        /// <param name="director">The director, that gets the Staff entity.</param>
        /// <param name="mainCharacter">The main character, that gets the Staff entity.</param>
        /// <param name="supportingCharacters">The supporting characters, that gets the Staff entity.</param>
        /// <param name="cost">The cost, that gets the Staff entity.</param>
        /// <param name="studio">The studio, that gets the Staff entity.</param>
        /// <param name="movieId">The movieId, that gets the Staff entity.</param>
        public void CreateStaff(string director, string mainCharacter, int supportingCharacters, int cost, string studio, int movieId)
        {
            Staff newStaff = new Staff
            {
                Director = director,
                MainCharacter = mainCharacter,
                SupportingCharacters = supportingCharacters,
                Cost = cost,
                Studio = studio,
                MovieId = movieId,
            };

            this.staffRepository.Create(newStaff);
        }

        /// <summary>
        /// Listing the average cost of movies grouped by categories.
        /// </summary>
        /// <returns>A list of average costs.</returns>
        public IList<MovieAverageCost> AverageCost()
        {
            var q = from staff in this.staffRepository.GetAll()
                    join movie in this.movieRepository.GetAll() on staff.MovieId equals movie.MovieId
                    let categories = new { Category = movie.Category, Cost = staff.Cost }
                    group categories by categories.Category into grp
                    select new MovieAverageCost()
                    { Category = grp.Key, Cost = grp.Average(staff => staff.Cost) };

            return q.ToList();
        }

        /// <summary>
        /// Listing the sum of supporting characters grouped by distributors.
        /// </summary>
        /// <returns>A list of sum of supporting characters.</returns>
        public IList<MovieSumCharacternumber> SumCharacternumber()
        {
            var q = from staff in this.staffRepository.GetAll()
                    join movie in this.movieRepository.GetAll() on staff.MovieId equals movie.MovieId
                    let distributors = new { Distributor = movie.Distributor, SupportingCharacters = staff.SupportingCharacters }
                    group distributors by distributors.Distributor into grp
                    select new MovieSumCharacternumber()
                    { Distributor = grp.Key, SupportingCharacters = grp.Sum(staff => staff.SupportingCharacters) };

            return q.ToList();
        }

        /// <summary>
        /// Async task: listing the average cost of movies grouped by categories.
        /// </summary>
        /// <returns>Average costs list in task.</returns>
        public Task<IList<MovieAverageCost>> AverageCostAsync()
        {
            return Task.Run(() => this.AverageCost());
        }

        /// <summary>
        /// Async task: listing the sum of supporting characters grouped by distributors.
        /// </summary>
        /// <returns>Sum of supporting characters list in task.</returns>
        public Task<IList<MovieSumCharacternumber>> SumCharacternumberAsync()
        {
            return Task.Run(() => this.SumCharacternumber());
        }
    }
}
