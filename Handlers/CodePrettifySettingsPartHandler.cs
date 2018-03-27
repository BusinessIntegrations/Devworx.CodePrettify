#region Using
using Devworx.CodePrettify.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
#endregion

namespace Devworx.CodePrettify.Handlers {
    public class CodePrettifySettingsPartHandler : ContentHandler {
        public CodePrettifySettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<CodePrettifySettingsPart>("Site"));
        }

        #region Properties
        public Localizer T { get; set; }
        #endregion

        #region Methods
        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site") {
                return;
            }
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Code-Prettify")));
        }
        #endregion
    }
}
