namespace ModularApp.Interfaces;

interface IModule : IFilterable
{
    /// <summary>
    /// Execute some action.
    /// </summary>
    /// <returns>
    /// Exit code of the action.
    /// </returns>
    int Run();

    /// <summary>
    /// Get the caption of the editor selection list.
    /// </summary>
    string GetListCaption();

    /// <summary>
    /// Get the line text in the editor selection list.
    /// </summary>
    Dictionary<string, IObject> GetListMapping();
}
