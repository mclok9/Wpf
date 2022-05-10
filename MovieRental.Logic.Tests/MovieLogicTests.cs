// <copyright file="MovieLogicTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Moq;
    using MovieRental.Data;
    using MovieRental.Repository;
    using NUnit.Framework;

    /// <summary>
    /// Class contains the MovieLogic for CRUD and non-CRUD logic tests.
    /// </summary>
    [TestFixture]
    public class MovieLogicTests
    {
        private Mock<IMovieRepository> mockedMovieRepository;
        private Mock<IStaffRepository> mockedStaffRepository;
        private List<MovieAverageCost> mockedAverageCost;
        private List<MovieSumCharacternumber> mockedSumCharacterNumber;
        private List<Movie> movies;

        /// <summary>
        /// Testing the working of GetOneMovie(int id) method.
        /// </summary>
        /// <param name="id">Adding the id to the mockedMovieRepository.</param>
        [TestCase(0)]
        [TestCase(2)]
        public void TestGetOneMovie(int id)
        {
            var logic = this.CreateMovieLogicMock();
            this.mockedMovieRepository.Setup(repository => repository.GetOne(It.Is<int>(id => id >= 0 && id <= this.movies.Count))).Returns(this.movies[id]);

            var result = logic.GetOneMovie(id);

            this.mockedMovieRepository.Verify(x => x.GetOne(id), Times.Exactly(1));
            this.mockedMovieRepository.Verify(x => x.GetAll(), Times.Never);
        }

        /// <summary>
        /// Testing the working of GetAllMovies() method.
        /// </summary>
        [Test]
        public void TestGetAllMovies()
        {
            var logic = this.CreateMovieLogicMock();

            var result = logic.GetAllMovies();

            this.mockedMovieRepository.Verify(x => x.GetAll(), Times.Once);
        }

        /// <summary>
        /// Testing the working of DeleteMovie(int id) method.
        /// </summary>
        /// <param name="id">Adding the id to the mockedMovieRepository.</param>
        [TestCase(1)]
        [TestCase(2)]
        public void TestDeleteMovie(int id)
        {
            var logic = this.CreateMovieLogicMock();

            logic.DeleteMovie(id);

            this.mockedMovieRepository.Verify(x => x.GetOne(id), Times.Once);
        }

        /// <summary>
        /// Testing the working of DeleteMovie(int id) method with a wrong id.
        /// </summary>
        /// <param name="id">Adding the id to the mockedMovieRepository.</param>
        [TestCase(-1)]
        public void TestDeleteMovieWrongId(int id)
        {
            var logic = this.CreateMovieLogicMock();

            logic.DeleteMovie(id);

            this.mockedMovieRepository.Verify(x => x.GetOne(id), Times.Once);
        }

        /// <summary>
        /// Testing the working of AverageCost() method.
        /// </summary>
        [Test]
        public void TestMovieAverageCost()
        {
            var logic = this.CreateMovieLogicMock();
            var value = logic.AverageCost();

            Assert.That(value, Is.EquivalentTo(this.mockedAverageCost));

            this.mockedMovieRepository.Verify(repository => repository.GetAll(), Times.Once);
            this.mockedStaffRepository.Verify(repository => repository.GetAll(), Times.Once);
        }

        /// <summary>
        /// Testing the working of SumCharacterNumber() method.
        /// </summary>
        [Test]
        public void TestMovieSumCharacterNumber()
        {
            var logic = this.CreateMovieLogicMock();
            var value = logic.SumCharacternumber();

            Assert.That(value, Is.EquivalentTo(this.mockedSumCharacterNumber));

            this.mockedMovieRepository.Verify(repository => repository.GetAll(), Times.Once);
            this.mockedStaffRepository.Verify(repository => repository.GetAll(), Times.Once);
        }

        private MovieLogic CreateMovieLogicMock()
        {
            this.mockedMovieRepository = new Mock<IMovieRepository>();
            this.mockedStaffRepository = new Mock<IStaffRepository>();

            Movie inception = new Movie() { MovieId = 1, Title = "Inception", Distributor = "InterCom", Category = "sci-fi", Length = "148 minutes", Language = "english" };
            Movie starWars = new Movie() { MovieId = 2, Title = "Star Wars: The Empire Strikes Back", Distributor = "Mokép", Category = "sci-fi", Length = "124 minutes", Language = "english" };
            Movie matrix = new Movie() { MovieId = 3, Title = "The Matrix", Distributor = "InterCom", Category = "action", Length = "136 minutes", Language = "english" };

            this.movies = new List<Movie>() { inception, starWars, matrix };

            List<Staff> staffs = new List<Staff>()
            {
                new Staff() { StaffId = 1, Director = "Christopher Nolan", MainCharacter = "Leonardo DiCaprio", SupportingCharacters = 36, Cost = 160000000, Studio = "Warner Brothers", MovieId = inception.MovieId },
                new Staff() { StaffId = 2, Director = "Irvin Kershner", MainCharacter = "Mark Hamill", SupportingCharacters = 51, Cost = 18000000, Studio = "Lucasfilm", MovieId = starWars.MovieId },
                new Staff() { StaffId = 3, Director = "Lana Wachowski", MainCharacter = "Keanu Reeves", SupportingCharacters = 16, Cost = 63000000, Studio = "Warner Brothers", MovieId = matrix.MovieId },
            };

            this.mockedAverageCost = new List<MovieAverageCost>()
            {
                new MovieAverageCost() { Category = "sci-fi", Cost = 89000000 },
                new MovieAverageCost() { Category = "action", Cost = 63000000 },
            };

            this.mockedSumCharacterNumber = new List<MovieSumCharacternumber>()
            {
                new MovieSumCharacternumber() { Distributor = "InterCom", SupportingCharacters = 52 },
                new MovieSumCharacternumber() { Distributor = "Mokép", SupportingCharacters = 51 },
            };

            this.mockedMovieRepository.Setup(repository => repository.GetAll()).Returns(this.movies.AsQueryable());
            this.mockedStaffRepository.Setup(repository => repository.GetAll()).Returns(staffs.AsQueryable());

            return new MovieLogic(this.mockedMovieRepository.Object, this.mockedStaffRepository.Object);
        }
    }
}
