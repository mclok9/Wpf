// <copyright file="RentFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MovieRental.Data;
    using MovieRental.Logic;
    using MovieRental.Repository;

    /// <summary>
    /// RentFactory class creates the logics and repositories for the Program class.
    /// </summary>
    public class RentFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RentFactory"/> class.
        /// </summary>
        public RentFactory()
        {
            RentContext ctx = new RentContext();

            MovieRepository movieRepository = new MovieRepository(ctx);
            RentRepository rentRepository = new RentRepository(ctx);
            RenterRepository renterRepository = new RenterRepository(ctx);
            StaffRepository staffRepository = new StaffRepository(ctx);

            this.MovieLogic = new MovieLogic(movieRepository, staffRepository);
            this.RentLogic = new RentLogic(rentRepository, renterRepository);
        }

        /// <summary>
        /// Gets or sets the MovieLogic.
        /// </summary>
        public MovieLogic MovieLogic { get; set; }

        /// <summary>
        /// Gets or sets the RentLogic.
        /// </summary>
        public RentLogic RentLogic { get; set; }
    }
}
