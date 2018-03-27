#region Using
using System.Collections.Generic;
using Devworx.CodePrettify.Models;
#endregion

namespace Devworx.CodePrettify.ViewModels {
    public class CodePrettifySettingsViewModel {
        #region Properties
        public CodePrettifySettingsPart PrettifySettingsPart { get; set; }
        public IEnumerable<string> Themes { get; set; }
        #endregion
    }
}
