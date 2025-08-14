using ModularApp.Objects;

namespace ModularApp.Modules;

class ModuleJobs : IModule
{
    public static string Name = "Aufgaben";

    public List<Job> Jobs = [];

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