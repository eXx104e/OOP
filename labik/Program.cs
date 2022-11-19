class BankAccount1
{
    ulong account_number;
    uint balance;
    public enum AccountType1
    {
        Расчетный, Накопительный, Кредитный, Инвестиционный, Пенсионный
    }
    AccountType1 acc_type;
    public BankAccount1(ulong account_number, uint balance, AccountType1 acc_type)
    {
        this.account_number = account_number;
        this.balance = balance;
        this.acc_type = acc_type;
    }
    public void SwitchAccountBank1(ulong account_number, uint balance, AccountType1 acc_type)
    {
        this.account_number = account_number;
        this.balance = balance;
        this.acc_type = acc_type;
    }
    public void PrintAccountBank1()
    {
        Console.WriteLine($"Номер счета - {account_number}, баланс - {balance} рублей, тип счета - {acc_type}");
    }
}

class BankAccount2
{
    Random random = new Random();
    public static int account_number;
    uint balance;
    public enum AccountType2
    {
        Расчетный, Накопительный, Кредитный, Инвестиционный, Пенсионный
    }
    AccountType2 acc_type;
    public BankAccount2(uint balance, AccountType2 acc_type)
    {
        this.balance = balance;
        this.acc_type = acc_type;
        account_number = random.Next();
    }
    public void SwitchAccountBank2(uint balance, AccountType2 acc_type)
    {
        this.balance = balance;
        this.acc_type = acc_type;
        account_number = random.Next();
    }
    public void PrintAccountBank2()
    {
        Console.WriteLine($"Номер счета - {account_number}, баланс - {balance} рублей, тип счета - {acc_type}");
    }
}

class BankAccount3
{
    ulong account_number;
    uint balance;
    public enum AccountType3
    {
        Расчетный, Накопительный, Кредитный, Инвестиционный, Пенсионный
    }
    AccountType3 acc_type;
    public BankAccount3(ulong account_number, uint balance, AccountType3 acc_type)
    {
        this.account_number = account_number;
        this.balance = balance;
        this.acc_type = acc_type;
    }
    public void SwitchAccountBank3(ulong account_number, uint balance, AccountType3 acc_type)
    {
        this.account_number = account_number;
        this.balance = balance;
        this.acc_type = acc_type;
    }
    public void PrintAccountBank3()
    {
        Console.WriteLine($"Номер счета - {account_number}, баланс - {balance} рублей, тип счета - {acc_type}");
    }
    public static void WithdrawMoney(uint cash, BankAccount3 account)
    {
        if (cash <= account.balance)
        {
            account.balance = account.balance - cash;
            Console.WriteLine($"текущий баланс - {account.balance}");
        }
        else
        {
            Console.WriteLine($"Недостаточно денег для снятия {cash} \n" +
                $"текущий баланс - {account.balance}");
        }
    }
}


class Program
{
    static void Main(String[] args)
    {

        Console.WriteLine("Задание 1");
        Console.WriteLine();
        BankAccount1 account1 = new BankAccount1(241921424, 15000, BankAccount1.AccountType1.Накопительный);
        account1.PrintAccountBank1();
        account1.SwitchAccountBank1(42121551, 21000, BankAccount1.AccountType1.Инвестиционный);
        account1.PrintAccountBank1();


        Console.WriteLine("Задание 2");
        Console.WriteLine();
        BankAccount2 account2 = new BankAccount2(15000, BankAccount2.AccountType2.Накопительный);
        account2.PrintAccountBank2();
        account2.SwitchAccountBank2(21000, BankAccount2.AccountType2.Инвестиционный);
        account2.PrintAccountBank2();
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Задание 3");
        Console.WriteLine();
        BankAccount3 account3 = new BankAccount3(241921424, 15000, BankAccount3.AccountType3.Накопительный);
        BankAccount3.WithdrawMoney(2314, account3);
        Console.ReadKey();
        Console.Clear();
    }
}
