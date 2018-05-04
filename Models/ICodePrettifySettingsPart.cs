namespace Devworx.CodePrettify.Models {
    public interface ICodePrettifySettingsPart {
        #region Properties
        /// <summary>
        ///     Gets or sets the name of the theme to use with code prettify
        /// </summary>
        string Theme { get; }

        bool UseAutoLoader { get; }
        #endregion
    }
}
