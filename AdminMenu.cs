#region Using
using Orchard.Localization;
using Orchard.UI.Navigation;
#endregion

namespace Devworx.CodePrettify {
    public class AdminMenu : INavigationProvider {
        public AdminMenu() {
            T = NullLocalizer.Instance;
        }

        #region INavigationProvider Members
        public void GetNavigation(NavigationBuilder builder) {
            builder.Add(T(Constants.AdminMenuName),
                "2.0.2",
                menu => menu.Permission(Permissions.ManageCodePrettifySettings)
                    .Action(Constants.IndexActionName,
                        Constants.AdminControllerName,
                        new {
                            area = Constants.AreaName
                        }),
                new[] {Constants.BiMenuSection});
        }

        public string MenuName => "admin";
        #endregion

        #region Properties
        public Localizer T { get; set; }
        #endregion
    }
}
