#region Using
using Devworx.CodePrettify.Models;
using Orchard.ContentManagement.Handlers;
#endregion

namespace Devworx.CodePrettify.Handlers {
    public class CodePrettifySettingsPartHandler : ContentHandler {
        public CodePrettifySettingsPartHandler() {
            Filters.Add(new ActivatingFilter<CodePrettifySettingsPart>(Constants.SiteContentTypeName));
        }
    }
}
