#region Using
using System.Collections.Generic;
using Devworx.CodePrettify.Models;
#endregion

namespace Devworx.CodePrettify.ViewModels {
    public class CodePrettifySettingsViewModel : ICodePrettifySettingsPart {
        #region ICodePrettifySettingsPart Members
        public string Theme { get; set; }
        public bool UseAutoLoader { get; set; }
        #endregion

        #region Properties
        public IEnumerable<string> Themes { get; set; }
        #endregion
    }
}
