using System;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Data.Extensions.MsSql;
using Aurochses.Module.Setting.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aurochses.Module.Setting.Data.Mappings
{
    /// <summary>
    /// Class SettingConfiguration.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.EntityTypeConfiguration{SettingEntity, Guid}" />
    public class SettingConfiguration : EntityTypeConfiguration<SettingEntity, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingConfiguration"/> class.
        /// </summary>
        /// <param name="schemaName">Name of the schema.</param>
        public SettingConfiguration(string schemaName)
            : base(schemaName)
        {

        }

        /// <summary>
        /// Maps the specified entity type builder.
        /// </summary>
        /// <param name="entityTypeBuilder">The entity type builder.</param>
        public override void Map(EntityTypeBuilder<SettingEntity> entityTypeBuilder)
        {
            // Table
            entityTypeBuilder.ToTable("Setting", SchemaName);

            // Primary Key
            entityTypeBuilder.HasKey(x => x.Id);

            // Properties
            entityTypeBuilder.Property(x => x.UniqueName).HasColumnType(ColumnTypes.GetNVarCharWithSpecifiedLength(ColumnLengths.UniqueName)).IsRequired();
            entityTypeBuilder.Property(x => x.Value).HasColumnType(ColumnTypes.NVarCharMax).IsRequired();

            // Index
            entityTypeBuilder.HasIndex(x => x.UniqueName).IsUnique();
        }
    }
}
