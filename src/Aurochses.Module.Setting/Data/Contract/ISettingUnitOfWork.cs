using System;
using Aurochses.Data;

namespace Aurochses.Module.Setting.Data.Contract
{
    /// <summary>
    /// Interface ISettingUnitOfWork
    /// </summary>
    /// <seealso cref="Aurochses.Data.IUnitOfWork" />
    public interface ISettingUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Gets the setting repository.
        /// </summary>
        /// <value>The setting repository.</value>
        IRepository<SettingEntity, Guid> SettingRepository
        {
            get;
        }
    }
}