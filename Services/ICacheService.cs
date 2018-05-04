#region Using
using Devworx.CodePrettify.Models;
using Orchard;
#endregion

namespace Devworx.CodePrettify.Services {
    public interface ICacheService : IDependency {
        #region Methods
        ICacheModel GetData();
        ICodePrettifySettingsPart GetSettings();
        void ReleaseCache();
        void UpdateSettings(ICodePrettifySettingsPart settings);
        #endregion
    }
}
