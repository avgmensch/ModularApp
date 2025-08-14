namespace ModularApp.Interfaces;

interface IFilterable
{
    /// <summary>
    /// Check of the object matches the <paramref name="query"/>.
    /// </summary>
    /// <param name="query">
    /// Search text.
    /// </param>
    bool DoesMatchSearchString(string query);
}