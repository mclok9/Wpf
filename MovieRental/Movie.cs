// <copyright file="Movie.cs" company="PlaceholderCompany">
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
    /// Movie class of the DataModel.
    /// </summary>
    [Table("Movies")]
    public class Movie
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        public Movie()
        {
            this.Staffs = new HashSet<Staff>();
        }

        /// <summary>
        /// Gets or sets the id of a Movie entity.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ToString]
        public int MovieId { get; set; }

        /// <summary>
        /// Gets or sets the title of a Movie entity.
        /// </summary>
        [Required]
        [MaxLength(100)]
        [ToString]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the distributor of a Movie entity.
        /// </summary>
        [Required]
        [MaxLength(100)]
        [ToString]
        public string Distributor { get; set; }

        /// <summary>
        /// Gets or sets the categoy of a Movie entity.
        /// </summary>
        [MaxLength(100)]
        [ToString]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the length of a Movie entity.
        /// </summary>
        [ToString]
        public string Length { get; set; }

        /// <summary>
        /// Gets or sets the language of a Movie entity.
        /// </summary>
        [ToString]
        public string Language { get; set; }

        /// <summary>
        /// Gets the collection of staffs of a Movie entity.
        /// </summary>
        [NotMapped]
        public virtual ICollection<Staff> Staffs { get; }

        /// <summary>
        /// Gets or sets the Rent of a Movie entity.
        /// </summary>
        [NotMapped]
        public virtual Rent Rent { get; set; }

        /// <summary>
        /// Gets or sets the rentId(foreign key) of a Movie entity.
        /// </summary>
        [ForeignKey(nameof(Rent))]
        public int RentId { get; set; }

        /// <summary>
        /// Gets the mainData of a Movie entity.
        /// </summary>
        [NotMapped]
        public string MainData => $"[MovieId: {this.MovieId}]  {this.Title} : {this.Distributor} : {this.Category} \n {this.Length} : {this.Language} (Staffs: {this.Staffs.Count}) (RentId: {this.RentId})";

        /// <summary>
        /// Overriding the ToString method.
        /// </summary>
        /// <returns>The string of a Movie entity.</returns>
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
            s += "Staffs\t=>";
            s += this.Staffs.Count;

            return s;
        }
    }
}
