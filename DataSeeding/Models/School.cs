﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Models
{
    internal class School
    {
        #region Properties
        public int? Id { get; set; }
        public string? Name { get; set; }
        #endregion

        #region Navigation Properties
        /*
         * - using 'virtual' keyword => EF create a proxy class At runtime, which enables features such as lazy loading and change tracking 
         * - Lazy loading means that related entities are not loaded from the database until you access the navigation property
         * - If we didn't use 'virtual' so we can use '.Include()' the property to eager loading the related entities
         */
        public virtual ICollection<Student>? Students { get; set; }
        #endregion
    }
}
