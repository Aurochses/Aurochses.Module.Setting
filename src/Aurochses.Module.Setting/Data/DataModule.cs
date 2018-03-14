using System;
using Aurochses.Data;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Data.Autofac;
using Aurochses.Module.Setting.Data.Contract;
using Autofac;

namespace Aurochses.Module.Setting.Data
{
    /// <summary>
    /// Class DataModule.
    /// </summary>
    /// <seealso cref="Aurochses.Module.Data.Autofac.DataModuleBase" />
    public class DataModule : DataModuleBase
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be registered.</param>
        /// <remarks>Note that the ContainerBuilder parameter is unique to this module.</remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Repository<SettingEntity, Guid>>().As<IRepository<SettingEntity, Guid>>().InstancePerLifetimeScope();
        }
    }
}