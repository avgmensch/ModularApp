using ModularApp.Modules;

namespace ModularApp;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, IRunnable> modules = new()
        {
            { ModuleContacts.Name, new ModuleContacts() },
            { ModuleTasks.Name, new ModuleTasks() }
        };

        Console.Write($"Wählen sie ein Modul aus: {string.Join(", ", modules.Keys)}\n>");

        string userInput = Console.ReadLine() ?? string.Empty;

        IRunnable? selectedModule = modules.GetValueOrDefault(userInput);

        if (selectedModule is null)
        {
            Console.WriteLine($"Das folgende Modul wurde nicht gefunden: '{userInput}'");
        }
        else
        {
            selectedModule.Run();
        }
    }
}
