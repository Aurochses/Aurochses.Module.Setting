using System;
using Aurochses.Data.EntityFrameworkCore;

namespace Aurochses.Module.Setting.Data.Contract
{
    /// <summary>
    /// Class SettingEntity.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.Entity{Guid}" />
    public class SettingEntity : Entity<Guid>
    {
        /// <summary>
        /// Gets or sets the name of the unique.
        /// </summary>
        /// <value>The name of the unique.</value>
        public string UniqueName { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }
    }
}