// <copyright file="ToStringAttribute.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ToStringAttribute using on properites.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ToStringAttribute : Attribute
    {
    }
}
