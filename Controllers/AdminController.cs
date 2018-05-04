#region Using
using System.Web.Mvc;
using Devworx.CodePrettify.Models;
using Devworx.CodePrettify.Services;
using Devworx.CodePrettify.ViewModels;
using Orchard;
using Orchard.Localization;
using Orchard.Themes;
using Orchard.UI.Admin;
using Orchard.UI.Notify;
#endregion

namespace Devworx.CodePrettify.Controllers {
    [Themed]
    [Admin]
    public class AdminController : Controller {
        private readonly ICacheService _cacheService;
        private readonly IOrchardServices _orchardServices;

        public AdminController(IOrchardServices orchardServices, ICacheService cacheService) {
            _orchardServices = orchardServices;
            _cacheService = cacheService;
            T = NullLocalizer.Instance;
        }

        #region Properties
        public Localizer T { get; set; }
        #endregion

        #region Methods
        public ActionResult Index() {
            if (!_orchardServices.Authorizer.Authorize(Permissions.ManageCodePrettifySettings, T(Constants.CannotManageText))) {
                return new HttpUnauthorizedResult();
            }

            var prettifySettingsViewModel = GetViewModel();
            return View(prettifySettingsViewModel);
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexPost(CodePrettifySettingsViewModel model) {
            if (!_orchardServices.Authorizer.Authorize(Permissions.ManageCodePrettifySettings, T(Constants.CannotManageText))) {
                return new HttpUnauthorizedResult();
            }

            if (ModelState.IsValid) {
                if (TryUpdateModel(model)) {
                    UpdatePart(model);
                    _orchardServices.Notifier.Information(T("Code-Prettify settings saved successfully."));
                    _orchardServices.Notifier.Information(T("Remember if you are using the Output Cache that you need to clear it."));
                }
                else {
                    _orchardServices.Notifier.Information(T("Could not save Code-Prettify settings."));
                }
            }
            else {
                _orchardServices.Notifier.Error(T(Constants.ValidationErrorText));
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        private CodePrettifySettingsViewModel GetViewModel() {
            var settingsPart = _cacheService.GetSettings();
            return new CodePrettifySettingsViewModel {
                Theme = settingsPart.Theme,
                UseAutoLoader = settingsPart.UseAutoLoader,
                Themes = Constants.Themes
            };
        }

        private void UpdatePart(ICodePrettifySettingsPart model) {
            _cacheService.UpdateSettings(model);
        }
        #endregion
    }
}
