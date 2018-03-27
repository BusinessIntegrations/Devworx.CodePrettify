#region Using
using Devworx.CodePrettify.Models;
using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
#endregion

namespace Devworx.CodePrettify.Drivers {
    public class CodePrettifyPartDriver : ContentPartDriver<CodePrettifyPart> {
        private readonly IOrchardServices _services;

        public CodePrettifyPartDriver(IOrchardServices services) {
            _services = services;
        }

        #region Methods
        protected override DriverResult Display(CodePrettifyPart part, string displayType, dynamic shapeHelper) {
            var settings = _services.WorkContext.CurrentSite.As<CodePrettifySettingsPart>();
            var themeName = settings.Theme;
            return ContentShape("CodePrettify", () => shapeHelper.CodePrettify(ThemeName: themeName, UseAutoLoader: settings.UseAutoLoader));
        }
        #endregion
    }
}
