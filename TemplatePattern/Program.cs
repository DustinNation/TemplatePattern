/*Let's make some Tea*/

using TemplatePattern.Standard;
using TemplatePattern.WithHook;

var tea = new Tea();

tea.PrepareBeverage();

Console.WriteLine();
Console.WriteLine();

/*Let's make some coffee*/

var coffee = new Coffee();
coffee.PrepareBeverage();

Console.WriteLine();
Console.WriteLine();

/*Let's make some tea with a hook*/
var teaWithHook = new TeaWithHook();
teaWithHook.PrepareBeverage();

Console.WriteLine();
Console.WriteLine();

/*Let's make some coffee with a hook*/
var coffeeWithHook = new CoffeeWithHook();
coffeeWithHook.PrepareBeverage();