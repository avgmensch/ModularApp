namespace ModularApp.Utilities;

static class Selector
{
    public static Tuple<TValue?, MetaAction?> SelectValue<TValue>(string prompt, Dictionary<string, TValue> options, bool showNumber = true, bool enableQuit = false, bool enableBack = false)
    {
        // TODO: Take height limit of the console into account.

        Dictionary<string, TValue> filteredOptions = [];
        int selectedIndex = 0;
        string searchTerm = "";

        while (true)
        {
            Console.Clear();
            Console.WriteLine(prompt);

            filteredOptions = options
                .Where(pair => pair.Key.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            int keyIndex = 0;
            foreach (string key in filteredOptions.Keys)
            {
                if (keyIndex == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                if (showNumber)
                {
                    Console.Write($"{keyIndex + 1}. ");
                }
                Console.WriteLine(key);
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
                selectedIndex = 0;
            }
            else if (char.IsLetterOrDigit(keyDownInfo.KeyChar))
            {
                searchTerm += keyDownInfo.KeyChar;
                selectedIndex = 0;
            }
            else if (keyDownInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
            {
                MetaAction? metaAction;

                if (enableQuit && keyDown == ConsoleKey.Q)
                {
                    metaAction = MetaAction.Quit;
                }
                else if (enableBack && keyDown == ConsoleKey.X)
                {
                    metaAction = MetaAction.Back;
                }
                else
                {
                    continue;
                }

                return Tuple.Create<TValue?, MetaAction?>(default, metaAction);
            }
        }

        TValue selectedValue = filteredOptions.Values.ElementAt(selectedIndex);

        return Tuple.Create<TValue?, MetaAction?>(selectedValue, default);
    }
}