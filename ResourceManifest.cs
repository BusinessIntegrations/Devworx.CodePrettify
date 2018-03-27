#region Using
using Orchard.UI.Resources;
#endregion

namespace Devworx.CodePrettify {
    public class ResourceManifest : IResourceManifestProvider {
        #region IResourceManifestProvider Members
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            //Styles
            manifest.DefineStyle("prettify-default")
                .SetUrl("prettify.min.css", "prettify.css")
                .SetCdn("https://cdn.rawgit.com/google/code-prettify/master/loader/prettify.css");
            manifest.DefineStyle("prettify-desert")
                .SetUrl("desert.min.css", "desert.css")
                .SetCdn("https://cdn.rawgit.com/google/code-prettify/master/loader/skins/desert.css")
                .SetVersion("1.298");
            manifest.DefineStyle("prettify-desert")
                .SetUrl("doxy.min.css", "doxy.css")
                .SetCdn("https://cdn.rawgit.com/google/code-prettify/master/loader/skins/doxy.css")
                .SetVersion("1.298");
            manifest.DefineStyle("prettify-github")
                .SetUrl("github.min.css", "github.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-hemisu-dark")
                .SetUrl("hemisu-dark.min.css", "hemisu-dark.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-hemisu-light")
                .SetUrl("hemisu-light.min.css", "hemisu-light.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-sons-of-obsidian")
                .SetUrl("sons-of-obsidian.min.css", "sons-of-obsidian.css")
                .SetCdn("https://cdn.rawgit.com/google/code-prettify/master/loader/skins/sons-of-obsidian.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-sunburst")
                .SetUrl("sunburst.min.css", "sunburst.css")
                .SetCdn("https://cdn.rawgit.com/google/code-prettify/master/loader/skins/sunburst.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow-night-blue")
                .SetUrl("tomorrow-night-blue.min.css", "tomorrow-night-blue.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow-night-bright")
                .SetUrl("tomorrow-night-bright.min.css", "tomorrow-night-bright.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow-night-eighties")
                .SetUrl("tomorrow-night-eighties.min.css", "tomorrow-night-eighties.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow-night")
                .SetUrl("tomorrow-night.min.css", "tomorrow-night.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow")
                .SetUrl("tomorrow.min.css", "tomorrow.css")
                .SetVersion("1.0");
            manifest.DefineStyle("prettify-vibrant-ink")
                .SetUrl("vibrant-ink.min.css", "vibrant-ink.css")
                .SetVersion("1.0");

            // Scripts
            manifest.DefineScript("prettify-js")
                .SetUrl("prettify.js")
                .SetCdn("https://cdn.rawgit.com/google/code-prettify/master/loader/prettify.js");
        }
        #endregion
    }
}
