using ModularApp.Interfaces;

namespace ModularApp.Modules;

class ModuleContacts : IModule
{
    public static string Name = "Kontakte";

    public bool DoesMatchSearchString(string query)
    {
        return Name.Contains(query, StringComparison.InvariantCultureIgnoreCase);
    }

    public int Run()
    {
        Console.WriteLine($"Modul geladen: {Name}");
        throw new NotImplementedException();
    }

    public string GetListCaption()
    {
        throw new NotImplementedException();
    }

    public Dictionary<string, IObject> GetListMapping()
    {
        throw new NotImplementedException();
    }
}