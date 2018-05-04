#region Using
using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;
using Orchard.Security.Permissions;
#endregion

namespace Devworx.CodePrettify {
    public class Permissions : IPermissionProvider {
        public static readonly Permission ManageCodePrettifySettings = new Permission {
            Description = "Managing Devworx Code-Prettify Settings",
            Name = nameof(ManageCodePrettifySettings)
        };

        private static readonly Permission[] permissions = {ManageCodePrettifySettings};

        #region IPermissionProvider Members
        public IEnumerable<PermissionStereotype> GetDefaultStereotypes() {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = permissions
                }
            };
        }

        public IEnumerable<Permission> GetPermissions() {
            return permissions;
        }

        public virtual Feature Feature { get; set; }
        #endregion
    }
}
