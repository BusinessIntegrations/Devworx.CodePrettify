#region Using
using Orchard.ContentManagement;
#endregion

namespace Devworx.CodePrettify.Models {
    /// <summary>
    ///     Holds the settings for the code prettify module.
    /// </summary>
    public class CodePrettifySettingsPart : ContentPart {
        #region Properties
        /// <summary>
        ///     Gets or sets the name of the theme to use with code prettify
        /// </summary>
        public string Theme { get { return this.Retrieve(x => x.Theme); } set { this.Store(x => x.Theme, value); } }

        public bool UseAutoLoader { get { return this.Retrieve(x => x.UseAutoLoader); } set { this.Store(x => x.UseAutoLoader, value); } }
        #endregion
    }
}
