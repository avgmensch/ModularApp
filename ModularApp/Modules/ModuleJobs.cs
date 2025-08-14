using ModularApp.Interfaces;
using ModularApp.Objects;
using ModularApp.Utilities;

namespace ModularApp.Modules;

class ModuleJobs : IModule
{
    public static string Name = "Aufgaben";

    public List<Job> Jobs = [];

    public bool DoesMatchSearchString(string query)
    {
        return Name.Contains(query, StringComparison.InvariantCultureIgnoreCase);
    }

    public int Run()
    {
        while (true)
        {
            var (selectedObject, selectedAction) = Selector.SelectValue(GetListCaption(), GetListMapping(), false, false, true);

            if (selectedObject is not null)
            {
                selectedObject.OpenEditor();
            }
            else if (selectedAction is not null)
            {
                switch (selectedAction)
                {
                    case MetaAction.Back:
                        return 0;
                }
            }
        }
    }

    public string GetListCaption()
    {
        return "Caption";
    }

    public Dictionary<string, IObject> GetListMapping()
    {
        return Jobs.ToDictionary(job => $"{job.Number} | {job.Name}", job => (IObject)job);
    }
}