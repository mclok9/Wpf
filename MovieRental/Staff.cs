// <copyright file="Staff.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Staff class of the DataModel.
    /// </summary>
    [Table("Staffs")]
    public class Staff
    {
        /// <summary>
        /// Gets or sets the id of a Staff entity.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ToString]
        public int StaffId { get; set; }

        /// <summary>
        /// Gets or sets the director of a Staff entity.
        /// </summary>
        [Required]
        [MaxLength(100)]
        [ToString]
        public string Director { get; set; }

        /// <summary>
        /// Gets or sets the main character of a Staff entity.
        /// </summary>
        [MaxLength(100)]
        [ToString]
        public string MainCharacter { get; set; }

        /// <summary>
        /// Gets or sets the supporting characters of a Staff entity.
        /// </summary>
        [ToString]
        public int SupportingCharacters { get; set; }

        /// <summary>
        /// Gets or sets the cost of a Staff entity.
        /// </summary>
        [ToString]
        public int Cost { get; set; }

        /// <summary>
        /// Gets or sets the studio of a Staff entity.
        /// </summary>
        [Required]
        [MaxLength(100)]
        [ToString]
        public string Studio { get; set; }

        /// <summary>
        /// Gets or sets the Movie of a Staff entity.
        /// </summary>
        [NotMapped]
        public virtual Movie Movie { get; set; }

        /// <summary>
        /// Gets or sets the movieId(foreign key) of a Staff entity.
        /// </summary>
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        /// <summary>
        /// Gets the mainData of a Staff entity.
        /// </summary>
        [NotMapped]
        public string MainData => $"[StaffId: {this.StaffId}] {this.Director} : {this.MainCharacter} (SupportingCharacters: {this.SupportingCharacters}) \n (Cost: {this.Cost}) {this.Studio} (MovieId: {this.MovieId})";

        /// <summary>
        /// Overriding a ToString method.
        /// </summary>
        /// <returns>A string of a Staff entity.</returns>
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
