// <copyright file="MovieSumCharacternumber.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for movies' sum of supporting characters grouped by distributors.
    /// </summary>
    public class MovieSumCharacternumber
    {
        /// <summary>
        /// Gets or sets the distributor of the movie.
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// Gets or sets the the sum of supporting characters of the movie.
        /// </summary>
        public int SupportingCharacters { get; set; }

        /// <summary>
        /// Overriding the ToString method.
        /// </summary>
        /// <returns>The string of a MovieSumCharacternumber entity.</returns>
        public override string ToString()
        {
            return $"Distributor = {this.Distributor}, Sum of supporting characters' number = {this.SupportingCharacters}";
        }

        /// <summary>
        /// Overriding the Equals method.
        /// </summary>
        /// <param name="obj">The object, what to check if it is from MovieSumCharacternumber class.</param>
        /// <returns>True, if the object is equal with MovieSumCharacternumber class.</returns>
        public override bool Equals(object obj)
        {
            if (obj is MovieSumCharacternumber)
            {
                MovieSumCharacternumber other = obj as MovieSumCharacternumber;
                return this.Distributor == other.Distributor && this.SupportingCharacters == other.SupportingCharacters;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Overriding the GetHashCode method.
        /// </summary>
        /// <returns>The actual object's number of supporting characters.</returns>
        public override int GetHashCode()
        {
            return Convert.ToInt32(this.SupportingCharacters).GetHashCode();
        }
    }
}
