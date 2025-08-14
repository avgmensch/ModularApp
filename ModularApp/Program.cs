using ModularApp.Modules;
using ModularApp.Utilities;

namespace ModularApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        ModuleContacts moduleContacts = new();

        ModuleJobs moduleJobs = new();

        moduleJobs.Jobs.AddRange([
            new("2508-001", "Einkaufsliste schreiben", "Erstelle eine Liste mit den wichtigsten Lebensmitteln, die du diese Woche brauchst."),
            new("2508-002", "5-Minuten-Meditation", "Setze dich ruhig hin, atme tief durch und konzentriere dich für fünf Minuten nur auf deinen Atem."),
            new("2508-003", "E-Mail aufräumen", "Lösche oder archiviere alte E-Mails, die du nicht mehr brauchst."),
            new("2508-004", "Glas Wasser trinken", "Trinke ein großes Glas Wasser, um deinen Körper zu erfrischen."),
            new("2508-005", "1 Schublade aufräumen", "Wähle eine kleine Schublade aus und sortiere sie ordentlich neu."),
            new("2508-006", "Einen Freund kontaktieren", "Schreib jemandem eine kurze Nachricht, um dich zu melden oder nachzufragen, wie es ihm geht."),
            new("2508-007", "5 Dinge notieren, für die du dankbar bist", "Schreibe auf, was dir heute positiv aufgefallen ist oder wofür du dankbar bist."),
            new("2508-008", "10 Kniebeugen machen", "Kleine Bewegungseinheit für zwischendurch - dauert nur eine Minute."),
            new("2508-009", "1 Kapitel lesen", "Lies ein Kapitel in einem Buch oder Artikel, der dich interessiert."),
            new("2508-010", "To-do-Liste für morgen schreiben", "Plane kurz den nächsten Tag, um strukturierter zu starten.")
        ]);

        Dictionary<string, IModule> modules = new()
        {
            { ModuleContacts.Name, moduleContacts },
            { ModuleJobs.Name, moduleJobs }
        };

        var (selectedModule, selectedAction) = Selector.SelectValue("Bitte wählen Sie ein Modul aus.", modules, true, true, false);

        if (selectedModule is not null)
        {
            selectedModule.Run();
        }
        else if (selectedAction is not null)
        {
            Console.WriteLine(selectedAction);

            if (selectedAction == MetaAction.Quit)
            {
                Console.WriteLine("Quitting application.");
                Environment.Exit(0);
            }
        }
    }
}
