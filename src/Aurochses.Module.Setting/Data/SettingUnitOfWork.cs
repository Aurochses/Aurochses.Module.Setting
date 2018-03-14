using System;
using Aurochses.Data;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Setting.Data.Contract;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Setting.Data
{
    /// <summary>
    /// Class SettingUnitOfWork.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.UnitOfWork" />
    /// <seealso cref="Aurochses.Module.Setting.Data.Contract.ISettingUnitOfWork" />
    public class SettingUnitOfWork : UnitOfWork, ISettingUnitOfWork
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingUnitOfWork"/> class.
        /// </summary>
        /// <param name="settingRepository">The setting repository.</param>
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public SettingUnitOfWork(
            Func<DbContext, IRepository<SettingEntity, Guid>> settingRepository,
            DbContextOptions dbContextOptions,
            string schemaName)
            : base(new SettingDbContext(dbContextOptions, schemaName))
        {
            RegisterRepository(settingRepository(DbContext));
        }

        /// <summary>
        /// Gets the setting repository.
        /// </summary>
        /// <value>The setting repository.</value>
        public IRepository<SettingEntity, Guid> SettingRepository => GetRepository<SettingEntity, Guid>();
    }
}