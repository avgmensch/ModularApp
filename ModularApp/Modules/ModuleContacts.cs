namespace ModularApp.Modules;

class ModuleContacts : IRunnable
{
    public static string Name = "Kontakte";

    public int Run()
    {
        Console.WriteLine($"Modul geladen: {Name}");
        throw new NotImplementedException();
    }
}