// <copyright file="Rent.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    /// <summary>
    /// Rent class of the DataModel.
    /// </summary>
    [Table("Rents")]
    public class Rent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rent"/> class.
        /// </summary>
        public Rent()
        {
            this.Renters = new HashSet<Renter>();
            this.Movies = new HashSet<Movie>();
        }

        /// <summary>
        /// Gets or sets the id of a Rent entity.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ToString]
        public int RentId { get; set; }

        /// <summary>
        /// Gets or sets the order of a Rent entity.
        /// </summary>
        [Required]
        [ToString]
        public DateTime Order { get; set; }

        /// <summary>
        /// Gets or sets the price of a Rent entity.
        /// </summary>
        [Required]
        [ToString]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the start of the rental of a Rent entity.
        /// </summary>
        [ToString]
        public DateTime RentalStart { get; set; }

        /// <summary>
        /// Gets or sets the end of the rental of a Rent entity.
        /// </summary>
        [ToString]
        public DateTime RentalEnd { get; set; }

        /// <summary>
        /// Gets or sets the overrun fee of a Rent entity.
        /// </summary>
        [ToString]
        public int OverrunFee { get; set; }

        /// <summary>
        /// Gets the collection of renters of a Rent entity.
        /// </summary>
        [NotMapped]
        public virtual ICollection<Renter> Renters { get; }

        /// <summary>
        /// Gets the collection of movies of a Rent entity.
        /// </summary>
        [NotMapped]
        public virtual ICollection<Movie> Movies { get; }

        /// <summary>
        /// Gets the mainData of a Rent entity.
        /// </summary>
        [NotMapped]
        public string MainData => $"[RentId: {this.RentId}] (Order: {this.Order}) (Price: {this.Price}) \n (RentalStart: {this.RentalStart}) (RentalEnd: {this.RentalEnd}) \n (OverrunFee: {this.OverrunFee}) (Renters: {this.Renters.Count}) (Movies: {this.Movies.Count})";

        /// <summary>
        /// Overriding the ToString method.
        /// </summary>
        /// <returns>The string of a Rent entity.</returns>
        public override string ToString()
        {
            string s = " ";
            foreach (var prop in this.GetType().GetProperties().Where(x => x.GetCustomAttribute<ToStringAttribute>() != null))
            {
                s += "   ";
                s += prop.Name + "\t=>";
                s += prop.GetValue(this);
                s += "\n";
            }

            s += "   ";
            s += "Renters\t=>";
            s += this.Renters.Count;
            s += "   ";
            s += "Movies\t=>";
            s += this.Movies.Count;

            return s;
        }
    }
}
