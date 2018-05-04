namespace Devworx.CodePrettify.Services {
    public class CacheModel : ICacheModel {
        public CacheModel(string theme, bool useAutoLoader) {
            Theme = theme;
            UseAutoLoader = useAutoLoader;
            var src = Constants.CdnRawgitComRunPrettifyJs;
            if (!string.IsNullOrEmpty(theme)) {
                src += $"?skin={theme}";
            }

            // In case you haven't seen javascript in an MVC result filter today.
            Script = $"<script type=\"text/javascript\" async=\"async\" src=\"{src}\"></script>";
        }

        #region ICacheModel Members
        public string Script { get; }
        public string Theme { get; }
        public bool UseAutoLoader { get; }
        #endregion
    }
}
