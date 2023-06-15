using TemplatePattern.DuckSort;
using static System.Console;

Duck[] ducks =
{
    new("Daffy", 8),
    new("Dewey", 2),
    new("Howard", 7),
    new("Louie", 2),
    new("Donald", 10),
    new("Huey", 2)
};

// Print the list prior to sorting:
WriteLine("Before sorting:");
ducks.ToList().ForEach(duck => WriteLine(duck.ToString()));

Array.Sort(ducks);

WriteLine();
WriteLine();

// Print the list after sorting:
WriteLine("After Sorting:");
ducks.ToList().ForEach(duck => WriteLine(duck.ToString()));