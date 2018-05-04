#region Using
using Devworx.CodePrettify.Controllers;
#endregion

namespace Devworx.CodePrettify {
    public static class Constants {
        public const string AdminControllerName = "Admin";
        public const string AdminMenuName = "Code-Prettify";
        public const string AreaName = "Devworx.CodePrettify";
        public const string BiMenuSection = "bi-menu-section";
        public const string CacheKey = "Devworx.CodePrettify.CacheKey";
        public const string CacheTrigger = "Devworx.CodePrettify.Changed";
        public const string CannotManageText = "Can't manage Code-Prettify Settings";
        public const string IndexActionName = nameof(AdminController.Index);
        public const string MasterLoader = "https://cdn.rawgit.com/google/code-prettify/master/loader/";
        public const string SiteContentTypeName = "Site";
        public const string ValidationErrorText = "Validation error";

        #region Properties
        public static string CdnRawgitComPrettifyJs => $"{MasterLoader}/prettify.js";
        public static string CdnRawgitComRunPrettifyJs => $"{MasterLoader}/run_prettify.js";

        public static string[] Themes { get; } = {
            "default",
            "desert",
            "doxy",
            "github",
            "hemisu-dark",
            "hemisu-light",
            "sons-of-obsidian",
            "sunburst",
            "tomorrow-night-blue",
            "tomorrow-night-bright",
            "tomorrow-night-eighties",
            "tomorrow-night",
            "tomorrow",
            "vibrant-ink"
        };
        #endregion
    }
}
