// <copyright file="RenterSumPrice.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Logic
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for the renter's sum of prices grouped by cities.
    /// </summary>
    public class RenterSumPrice
    {
        /// <summary>
        /// Gets or sets the city of a renter.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the sum of prices of a renter.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Overriding the ToString method.
        /// </summary>
        /// <returns>The string of a RenterSumPrice entity.</returns>
        public override string ToString()
        {
            return $"City = {this.City}, Sum of prices = {this.Price}";
        }

        /// <summary>
        /// Overriding the Equals method.
        /// </summary>
        /// <param name="obj">The object, what to check if it is from RenterSumPrice class.</param>
        /// <returns>True, if the object is equal with RenterSumPrice class.</returns>
        public override bool Equals(object obj)
        {
            if (obj is RenterSumPrice)
            {
                RenterSumPrice other = obj as RenterSumPrice;
                return this.City == other.City && this.Price == other.Price;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Overriding the GetHashCode method.
        /// </summary>
        /// <returns>The actual object's price.</returns>
        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Price).GetHashCode();
        }
    }
}
