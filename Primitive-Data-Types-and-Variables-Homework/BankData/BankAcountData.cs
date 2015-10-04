using System;
    class BankAcountData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ime: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Prezime: " );
            string middleName = Console.ReadLine();
            Console.WriteLine("Familiq: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ime na banka: ");
            string bankName = Console.ReadLine();
            Console.WriteLine("IBAN: ");
            string IBAN = Console.ReadLine();
            Console.WriteLine("Credit card number: ");
            long creditCard1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Credit card number: ");
            long creditCard2 = long.Parse(Console.ReadLine());
            Console.WriteLine("Credit card number: ");
            long creditCard3 = long.Parse(Console.ReadLine());
        }
    }
