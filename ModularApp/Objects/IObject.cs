namespace ModularApp.Objects;

interface IObject
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
}