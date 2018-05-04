#region Using
using Devworx.CodePrettify.Models;
using Devworx.CodePrettify.Services;
using Orchard.ContentManagement.Drivers;
#endregion

namespace Devworx.CodePrettify.Drivers {
    public class CodePrettifyPartDriver : ContentPartDriver<CodePrettifyPart> {
        private readonly ICacheService _cacheService;

        public CodePrettifyPartDriver(ICacheService cacheService) {
            _cacheService = cacheService;
        }

        #region Methods
        protected override DriverResult Display(CodePrettifyPart part, string displayType, dynamic shapeHelper) {
            var cacheModel = _cacheService.GetData();
            var themeName = cacheModel.Theme;
            return ContentShape("CodePrettify", () => shapeHelper.CodePrettify(ThemeName: themeName, UseAutoLoader: cacheModel.UseAutoLoader));
        }
        #endregion
    }
}
