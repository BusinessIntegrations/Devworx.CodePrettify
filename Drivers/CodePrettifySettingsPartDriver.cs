#region Using
using System.Collections.Generic;
using Devworx.CodePrettify.Models;
using Devworx.CodePrettify.ViewModels;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Localization;
#endregion

namespace Devworx.CodePrettify.Drivers {
    public class CodePrettifySettingsPartDriver : ContentPartDriver<CodePrettifySettingsPart> {
        private const string TemplateName = "Parts/CodePrettifySettings";

        public CodePrettifySettingsPartDriver() {
            T = NullLocalizer.Instance;
        }

        #region Properties
        public Localizer T { get; set; }
        protected override string Prefix => "CodePrettifySettings";
        #endregion

        #region Methods
        protected override DriverResult Editor(CodePrettifySettingsPart part, dynamic shapeHelper) {
            return ContentShape("Parts_CodePrettifySettings_Edit",
                    () => {
                        var themes = GetThemes();
                        var viewModel = new CodePrettifySettingsViewModel {
                            PrettifySettingsPart = part,
                            Themes = themes
                        };
                        return shapeHelper.EditorTemplate(TemplateName: TemplateName, Model: viewModel, Prefix: Prefix);
                    })
                .OnGroup("code-prettify");
        }

        protected override DriverResult Editor(CodePrettifySettingsPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        private static IEnumerable<string> GetThemes() {
            return new[] {"default", "desert", "doxy", "github", "hemisu-dark", "hemisu-light", "sons-of-obsidian", "sunburst", "tomorrow-night-blue", "tomorrow-night-bright", "tomorrow-night-eighties", "tomorrow-night", "tomorrow", "vibrant-ink"};
        }
        #endregion
    }
}
