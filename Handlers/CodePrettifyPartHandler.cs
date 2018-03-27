#region Using
using Devworx.CodePrettify.Models;
using Orchard.ContentManagement.Handlers;
#endregion

namespace Devworx.CodePrettify.Handlers {
    public class CodePrettifyPartHandler : ContentHandler {
        public CodePrettifyPartHandler() {
            Filters.Add(new ActivatingFilter<CodePrettifyPart>("BlogPost"));
        }
    }
}
