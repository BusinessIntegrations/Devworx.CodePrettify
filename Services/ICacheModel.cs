namespace Devworx.CodePrettify.Services {
    public interface ICacheModel {
        #region Properties
        string Script { get; }
        string Theme { get; }
        bool UseAutoLoader { get; }
        #endregion
    }
}
