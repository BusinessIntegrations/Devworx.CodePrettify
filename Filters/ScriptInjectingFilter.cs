#region Using
using System.Web.Mvc;
using Devworx.CodePrettify.Services;
using Orchard.Mvc.Filters;
using Orchard.UI.Admin;
using Orchard.UI.Resources;
#endregion

namespace Devworx.CodePrettify.Filters {
    public class ScriptInjectingFilter : FilterProvider, IResultFilter {
        private readonly ICacheService _cacheService;
        private readonly IResourceManager _resourceManager;

        public ScriptInjectingFilter(IResourceManager resourceManager, ICacheService cacheService) {
            _resourceManager = resourceManager;
            _cacheService = cacheService;
        }

        #region IResultFilter Members
        public void OnResultExecuted(ResultExecutedContext filterContext) { }

        public void OnResultExecuting(ResultExecutingContext filterContext) {
            // Should only run on a full view rendering result only.
            if (!(filterContext.Result is ViewResult) ||
                AdminFilter.IsApplied(filterContext.RequestContext)) {
                return;
            }

            var cacheModel = _cacheService.GetData();
            if (cacheModel.UseAutoLoader) {
                _resourceManager.RegisterFootScript(cacheModel.Script);
            }
        }
        #endregion
    }
}
