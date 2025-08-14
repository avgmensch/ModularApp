using ModularApp.Interfaces;

namespace ModularApp.Objects;

class Job : IObject
{
    #region Default members
    public string Number { get; }

    public DateTime CreatedOn { get; }

    public string Name { get; set; }
    #endregion

    #region  Per type members
    public string Description { get; set; }

    private DateTime? finishedOn;
    public DateTime? FinishedOn
    {
        get
        {
            return finishedOn;
        }
        set
        {
            finishedOn = value;
            isFinished = value is not null;
        }
    }

    private bool? isFinished;
    public bool Finished
    {
        get
        {
            return isFinished ?? false;
        }
        set
        {
            isFinished = value;
            if (value) finishedOn = DateTime.Now;
        }
    }
    #endregion

    public Job(string number, string name, string description)
    {
        Number = number;
        CreatedOn = DateTime.Now;
        Name = name;
        Description = description;
    }

    public bool DoesMatchSearchString(string query)
    {
        List<string> searchFields = [Number, CreatedOn.ToString(), Name, Description, Finished.ToString()];
        if (FinishedOn is not null) searchFields.Add(FinishedOn.ToString() ?? string.Empty);
        return searchFields.Any(field => field.Contains(query, StringComparison.InvariantCultureIgnoreCase));
    }

    public int OpenEditor()
    {
        Console.WriteLine($"Editor geöffnet: {Number} | {Name}");
        throw new NotImplementedException();
    }
}