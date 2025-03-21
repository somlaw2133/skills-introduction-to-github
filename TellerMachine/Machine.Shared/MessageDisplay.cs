using System.Collections.Generic;
using System.Transactions;

namespace Machine.Shared;

public class MessageDisplay
{
    public const string WelcomeMsg = "Welcome to Bank of Lawrence. How May I assist you today";
    public const string TnxOptionsMsg = "Please Check the following options perform operations";
    public const string DepositMsg = "Deposit";
    public const string WithdrawMsg = "Withdraw";
    public const string CheckBalanceMsg = "Check Balance";
    public const string TransferMsg = "Transfer";

    public static List<TransactionOptions> TnxOptionList()
    {
        List<TransactionOptions> tnxOptions = new List<TransactionOptions>
        {
            {
                new TransactionOptions { OptionId = 1, OptionName = DepositMsg }
            },
            {
                new TransactionOptions { OptionId = 2, OptionName = WithdrawMsg }
            },
            {
                new TransactionOptions { OptionId = 3, OptionName = CheckBalanceMsg }
            },
            {
                new TransactionOptions { OptionId = 4, OptionName = TransferMsg }
            },
        };

        return tnxOptions;
    }
}
