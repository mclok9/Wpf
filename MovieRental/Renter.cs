// <copyright file="Renter.cs" company="PlaceholderCompany">
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
    /// Renter class of the DataModel.
    /// </summary>
    [Table("Renters")]
    public class Renter
    {
        /// <summary>
        /// Gets or sets the id of a Renter entity.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ToString]
        public int RenterId { get; set; }

        /// <summary>
        /// Gets or sets the name of a Renter entity.
        /// </summary>
        [Required]
        [MaxLength(100)]
        [ToString]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the postcode of a Renter entity.
        /// </summary>
        [ToString]
        public int Postcode { get; set; }

        /// <summary>
        /// Gets or sets the city of a Renter entity.
        /// </summary>
        [Required]
        [ToString]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the street of a Renter entity.
        /// </summary>
        [ToString]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the house number of a Renter entity.
        /// </summary>
        [ToString]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the start of the membership of a Rental entity.
        /// </summary>
        [ToString]
        public DateTime MembershipStart { get; set; }

        /// <summary>
        /// Gets or sets the end of the membership of a Rental entity.
        /// </summary>
        [ToString]
        public DateTime MembershipEnd { get; set; }

        /// <summary>
        /// Gets or sets the Rent of a Renter entity.
        /// </summary>
        [NotMapped]
        public virtual Rent Rent { get; set; }

        /// <summary>
        /// Gets or sets the rentId(foreign key) of a Renter entity.
        /// </summary>
        [ForeignKey(nameof(Rent))]
        public int RentId { get; set; }

        /// <summary>
        /// Gets the mainData of a Renter entity.
        /// </summary>
        [NotMapped]
        public string MainData => $"[RenterId: {this.RenterId}] : {this.Name} \n (Postcode: {this.Postcode}) : {this.City} : {this.Street} : {this.HouseNumber} \n (MembershipStart: {this.MembershipStart}) (MembershipEnd: {this.MembershipEnd}) (RentId: {this.RentId})";

        /// <summary>
        /// Overriding the ToString method.
        /// </summary>
        /// <returns>The string of a Renter entity.</returns>
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

            return s;
        }
    }
}
