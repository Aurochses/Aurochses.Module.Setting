using Aurochses.Module.Setting.Business.Contract;
using Aurochses.Module.Setting.Data.Contract;

namespace Aurochses.Module.Setting.Business
{
    /// <summary>
    /// Class SettingService.
    /// </summary>
    /// <seealso cref="ISettingService" />
    public class SettingService : ISettingService
    {
        private readonly ISettingUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingService"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        public SettingService(ISettingUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}