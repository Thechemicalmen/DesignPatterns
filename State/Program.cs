using State;

var account = new BankAccount(50);

account.Deposit(10);
account.Withdraw(100);

try
{
    account.Withdraw(100);
}
catch (CannotWithdrawOnNegativeBankAccountBalance)
{
    Console.WriteLine("Impossible de faire un retrait sur un compte négatif");
}

account.Deposit(100);
account.Withdraw(10);

account.Deposit(1000);
account.Deposit(10);
account.Withdraw(5000);

account.Deposit(6000);