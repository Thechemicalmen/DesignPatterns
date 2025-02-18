namespace State
{
    internal abstract class BankAccountState
    {
        public decimal Balance { get; set; }
        public BankAccount Account { get; set; }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }

    internal class PositiveBankAccountState : BankAccountState
    {
        public PositiveBankAccountState(decimal balance, BankAccount account)
        {
            Balance = balance;
            Account = account;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"Dépot de {amount}");
            Balance += amount;
            if(Balance > 1000)
            {
                Console.WriteLine("Passage a plus de 1000e, passage à un compte VIP");
                Account._state = new VIPBankAccountState()
                {
                    Balance = Balance,
                    Account = Account
                };
            }
        }
        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
            if(Balance < 0)
            {
                Console.WriteLine($"Le compte passe en négatif : {Balance}");
                Account._state = new NegativeBankAccountState(Account)
                {
                    Balance = Balance
                };
            }
        }
    }

    internal class VIPBankAccountState : BankAccountState
    {
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"Dépot sur le compte VIP : {amount}. Prime de 10% !");
            Balance += amount * 1.1m;
            Console.WriteLine($"Nouveau solde : {Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
            if(Balance < 1000 && Balance >= 0)
            {
                Console.WriteLine("Passage sous les 1000e, retour à un compte normal");
                Account._state = new PositiveBankAccountState(Balance, Account);
            }
            else if (Balance < 0)
            {
                Console.WriteLine("Passage sous 0e, passage à un compte négatif");
                Account._state = new NegativeBankAccountState(Account)
                {
                    Balance = Balance
                };
            }
        }
    }

    internal class NegativeBankAccountState : BankAccountState
    {
        public NegativeBankAccountState(BankAccount account) => Account = account;

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"Dépot sur compte négatif : {amount}");
            Balance += amount;
            if(Balance > 0 && Balance <= 1000)
            {
                Console.WriteLine("Le compte redevient positif");
                Account._state = new PositiveBankAccountState(Balance, Account);
            }
            else if (Balance > 1000)
            {
                Console.WriteLine("Passage a plus de 1000e, passage à un compte VIP");
                Account._state = new VIPBankAccountState()
                {
                    Balance = Balance,
                    Account = Account
                };
            }
        }
        public override void Withdraw(decimal amount) => throw new CannotWithdrawOnNegativeBankAccountBalance();
    }

    public class CannotWithdrawOnNegativeBankAccountBalance : Exception { }

    public class BankAccount
    {
        internal BankAccountState _state;
        public decimal Balance => _state.Balance;

        public BankAccount(decimal amount) => _state = new PositiveBankAccountState(amount, this);

        public void Withdraw(decimal amount) => _state.Withdraw(amount);
        public void Deposit(decimal amount) => _state.Deposit(amount);
    }
}