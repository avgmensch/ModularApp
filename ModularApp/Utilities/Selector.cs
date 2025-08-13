namespace ModularApp.Utilities;

static class Selector
{
    public static TValue SelectValue<TValue>(string prompt, Dictionary<string, TValue> options)
    {
        if (options.Count < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(options));
        }

        int selectedIndex = 0;
        string searchTerm = "";

        while (true)
        {
            Console.Clear();
            Console.WriteLine(prompt);

            int keyIndex = 0;
            foreach (string key in options.Keys)
            {
                if (!key.Contains(searchTerm, StringComparison.CurrentCultureIgnoreCase))
                {
                    continue;
                }
                else if (keyIndex == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{keyIndex + 1}. {key}");
                Console.ResetColor();
                keyIndex += 1;
            }

            Console.Write($"> {searchTerm}");
            ConsoleKeyInfo keyDownInfo = Console.ReadKey();
            ConsoleKey keyDown = keyDownInfo.Key;

            if (keyDown == ConsoleKey.Enter)
            {
                break;
            }
            else if (keyDown == ConsoleKey.UpArrow && selectedIndex > 0)
            {
                selectedIndex--;
            }
            else if (keyDown == ConsoleKey.DownArrow && selectedIndex < options.Count - 1)
            {
                selectedIndex++;
            }
            else if (keyDown == ConsoleKey.Backspace && searchTerm.Length > 0)
            {
                searchTerm = searchTerm[..^1];
            }
            else if (char.IsLetterOrDigit(keyDownInfo.KeyChar))
            {
                searchTerm += keyDownInfo.KeyChar;
            }
        }

        TValue selectedValue = options.Values.ElementAt(selectedIndex);

        return selectedValue;
    }
}