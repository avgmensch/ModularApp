namespace ModularApp.Modules;

class ModuleContacts : IModule
{
    public static string Name = "Kontakte";

    public int Run()
    {
        Console.WriteLine($"Modul geladen: {Name}");
        throw new NotImplementedException();
    }

    public string GetListCaption()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> GetListText()
    {
        throw new NotImplementedException();
    }
}