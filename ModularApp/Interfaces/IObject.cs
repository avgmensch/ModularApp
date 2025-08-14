namespace ModularApp.Interfaces;

interface IObject : IFilterable
{
    /// <summary>
    /// Number of the object (should be unique per type).
    /// </summary>
    string Number { get; }

    /// <summary>
    /// Time stamp of the object's creation.
    /// </summary>
    DateTime CreatedOn { get; }

    /// <summary>
    /// Display name of the object.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Opens the editor of an object.
    /// </summary>
    /// <returns>
    /// Exit code of the editor.
    /// </returns>
    int OpenEditor();
}