#region Using
using System.Web.Mvc;
using Devworx.CodePrettify.Models;
using Orchard.ContentManagement;
using Orchard.Mvc.Filters;
using Orchard.Settings;
using Orchard.UI.Admin;
using Orchard.UI.Resources;
#endregion

namespace Devworx.CodePrettify.Filters {
    public class ScriptInjectingFilter : FilterProvider, IResultFilter {
        private const string RunPrettifyJs = "https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js";
        private readonly IResourceManager _resourceManager;
        private readonly ISiteService _siteService;

        public ScriptInjectingFilter(ISiteService siteService, IResourceManager resourceManager) {
            _siteService = siteService;
            _resourceManager = resourceManager;
        }

        #region IResultFilter Members
        public void OnResultExecuted(ResultExecutedContext filterContext) { }

        public void OnResultExecuting(ResultExecutingContext filterContext) {
            // Should only run on a full view rendering result only.
            if (!(filterContext.Result is ViewResult) ||
                AdminFilter.IsApplied(filterContext.RequestContext)) {
                return;
            }
            var settings = _siteService.GetSiteSettings()
                .As<CodePrettifySettingsPart>();
            if (!settings.UseAutoLoader) {
                return;
            }
            var skin = settings.Theme;
            var src = RunPrettifyJs;
            if (!string.IsNullOrEmpty(skin)) {
                src += $"?skin={skin}";
            }

            // In case you haven't seen javascript in an MVC result filter today.
            _resourceManager.RegisterFootScript($"<script type=\"text/javascript\" async=\"async\" src=\"{src}\"></script>");
        }
        #endregion
    }
}
