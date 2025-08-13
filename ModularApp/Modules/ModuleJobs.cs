using ModularApp.Objects;

namespace ModularApp.Modules;

class ModuleJobs : IRunnable
{
    public static string Name = "Aufgaben";

    public static List<Job> Jobs = [];

    public int Run()
    {
        Console.WriteLine($"Modul geladen: {Name}");
        throw new NotImplementedException();
    }
}