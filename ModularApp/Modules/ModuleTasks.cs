namespace ModularApp.Modules;

class ModuleTasks : IRunnable
{
    public static string Name = "Aufgaben";

    public int Run()
    {
        Console.WriteLine($"Modul geladen: {Name}");
        throw new NotImplementedException();
    }
}