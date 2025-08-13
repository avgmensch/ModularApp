using ModularApp.Modules;
using ModularApp.Utilities;

namespace ModularApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Dictionary<string, IRunnable> modules = new()
        {
            { ModuleContacts.Name, new ModuleContacts() },
            { ModuleTasks.Name, new ModuleTasks() }
        };

        IRunnable selectedModule = Selector.SelectValue("Bitte wählen Sie ein Modul aus.", modules);

        selectedModule.Run();
    }
}
