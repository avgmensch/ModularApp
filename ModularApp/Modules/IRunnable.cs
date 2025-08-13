namespace ModularApp.Modules;

interface IRunnable
{
    /// <summary>
    /// Execute some action.
    /// </summary>
    /// <returns>
    /// Exit code of the action.
    /// </returns>
    int Run();
}
