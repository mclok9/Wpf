// <copyright file="MovieAverageCost.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for movies' average costs grouped by categories.
    /// </summary>
    public class MovieAverageCost
    {
        /// <summary>
        /// Gets or sets the category of the movie.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the average cost of the movie.
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Overriding the ToString method.
        /// </summary>
        /// <returns>The string of a MovieAverageCost entity.</returns>
        public override string ToString()
        {
            return $"Category = {this.Category}, Average cost = {this.Cost}";
        }

        /// <summary>
        /// Overriding the Equals method.
        /// </summary>
        /// <param name="obj">The object, what to check if it is from MovieAverageCost class.</param>
        /// <returns>True, if the object is equal with MovieAverageCost class.</returns>
        public override bool Equals(object obj)
        {
            if (obj is MovieAverageCost)
            {
                MovieAverageCost other = obj as MovieAverageCost;
                return this.Category == other.Category && this.Cost == other.Cost;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Overriding the GetHashCode method.
        /// </summary>
        /// <returns>The actual object's cost.</returns>
        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Cost).GetHashCode();
        }
    }
}
