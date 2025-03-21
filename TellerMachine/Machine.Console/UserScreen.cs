// Add a using statement which references the Machine.Shared
using Machine.Shared;

namespace Machine.Console;

public class UserScreen
{
    public static void DisplayServices()
    {
        System.Console.WriteLine(MessageDisplay.WelcomeMsg);

        System.Console.WriteLine(MessageDisplay.TnxOptionsMsg);

        List<TransactionOptions> options = MessageDisplay.TnxOptionList();

        for (int i = 0; i < options.Count; i++)
        {
            TransactionOptions? opt = options[i];
            System.Console.WriteLine($"... Please, choose {opt.OptionId} for {opt.OptionName}");
        }
    }
}
