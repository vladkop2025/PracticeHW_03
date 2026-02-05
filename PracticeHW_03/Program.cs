using System;


namespace PracticeHW_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Банковская система расчета процентов ===\n");
            // Создаем разные типы счетов
            Account regularAccount = new RegularAccount { Balance = 500 };
            Account salaryAccount = new SalaryAccount { Balance = 1500 };

            // Рассчитываем проценты для каждого счета
            Console.WriteLine("Расчет процентов для разных типов счетов:");
            Console.WriteLine(new string('-', 50));

            CalculateAndDisplay(regularAccount, "Обычный счет");
            CalculateAndDisplay(salaryAccount, "Зарплатный счет");
        }
        static void CalculateAndDisplay(Account account, string accountType)
        {
            Calculator.CalculateInterest(account);
            Console.WriteLine($"{accountType}:");
            Console.WriteLine($"  Баланс: {account.Balance:C}");
            Console.WriteLine($"  Начисленные проценты: {account.Interest:C}");
            Console.WriteLine($"  Итоговый баланс: {account.Balance + account.Interest:C}");
            Console.WriteLine();
        }
    }
}
